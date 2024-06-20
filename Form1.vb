Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form1
    Private filePathCSV As String
    Private filePathJSON As String
    Private filePathXML As String
    Private filePathTXT As String

#Region "OperationsCSV"
    Private Sub btnOpenCSV_Click(sender As Object, e As EventArgs) Handles btnOpenCSV.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        filePathCSV = openFileDialog.FileName
        ShowCSV_InDGV()
    End Sub

    Public Sub ShowCSV_InDGV()
        dgvTableCSV.Rows.Clear()
        dgvTableCSV.Columns.Clear()

        ' Leer las líneas del archivo CSV
        Dim lines As String() = File.ReadAllLines(filePathCSV)

        ' Si hay líneas en el archivo
        If lines.Length > 0 Then
            ' Obtener los nombres de las columnas del primer registro
            Dim columnNames As String() = lines(0).Split(","c)

            ' Agregar columnas al DataGridView usando los nombres de columna del CSV
            For Each columnName As String In columnNames
                dgvTableCSV.Columns.Add(columnName, columnName)
            Next

            ' Agregar filas al DataGridView con el contenido del CSV (excluyendo la primera línea)
            For i As Integer = 1 To lines.Length - 1
                Dim fields As String() = lines(i).Split(","c)
                dgvTableCSV.Rows.Add(fields)
            Next
        End If
    End Sub

    Private Sub btnSearchCSV_Click(sender As Object, e As EventArgs) Handles btnSearchCSV.Click
        If String.IsNullOrEmpty(filePathCSV) OrElse Not File.Exists(filePathCSV) Then
            MessageBox.Show("Select a file to work with.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtSearchCSV.Text = "" Then
            MessageBox.Show("To search, you must use a NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            ' Leer el archivo CSV línea por línea
            Using reader As New StreamReader(filePathCSV)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim fields As String() = line.Split(","c)

                    ' Comparar el término de búsqueda con el primer campo (en este caso, el nombre)
                    If fields.Length > 0 AndAlso fields(0) = txtSearchCSV.Text Then
                        MessageBox.Show("Found: " & String.Join(", ", fields), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error searching in the CSV file: " & ex.Message)
        End Try

        MessageBox.Show("No matching name found in the file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnSaveCSV_Click(sender As Object, e As EventArgs) Handles btnSaveCSV.Click
        ' Verificar si hay datos en el DataGridView
        If dgvTableCSV.Rows.Count = 0 Then
            MessageBox.Show("There is no data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtener la ruta del archivo CSV
        Dim filePath As String = filePathCSV

        Try
            ' Crear un StringBuilder para construir el contenido del archivo CSV
            Dim csvContent As New StringBuilder()

            ' Agregar encabezados de columna al archivo CSV
            For i As Integer = 0 To dgvTableCSV.Columns.Count - 1
                csvContent.Append(dgvTableCSV.Columns(i).HeaderText)
                If i < dgvTableCSV.Columns.Count - 1 Then
                    csvContent.Append(",")
                End If
            Next
            csvContent.AppendLine() ' Agregar nueva línea después de los encabezados

            ' Agregar datos de cada fila al archivo CSV
            For Each row As DataGridViewRow In dgvTableCSV.Rows
                Dim hasData As Boolean = False ' Bandera para verificar si la fila tiene celdas no vacías
                Dim rowData As New StringBuilder()

                For i As Integer = 0 To dgvTableCSV.Columns.Count - 1
                    ' Verificar si el valor de la celda no es nulo ni está vacío
                    If row.Cells(i).Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(row.Cells(i).Value.ToString()) Then
                        rowData.Append(row.Cells(i).Value.ToString())
                        hasData = True ' Establecer la bandera en verdadero si la celda tiene un valor no vacío
                    End If

                    If i < dgvTableCSV.Columns.Count - 1 Then
                        rowData.Append(",")
                    End If
                Next

                ' Agregar los datos de la fila al contenido del CSV si la fila tiene celdas no vacías
                If hasData Then
                    csvContent.AppendLine(rowData.ToString())
                End If
            Next

            ' Escribir el contenido en el archivo CSV
            File.WriteAllText(filePath, csvContent.ToString())

            MessageBox.Show("Data saved successfully to the CSV file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data to the CSV file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ShowCSV_InDGV()
    End Sub

    Private Sub btnDeleteCSV_Click(sender As Object, e As EventArgs) Handles btnDeleteCSV.Click
        ' Verificar si se ha seleccionado un archivo
        If String.IsNullOrWhiteSpace(filePathCSV) OrElse Not File.Exists(filePathCSV) Then
            MessageBox.Show("Select a valid file to work with.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Verificar si se ha ingresado un nombre para buscar
        If String.IsNullOrWhiteSpace(txtSearchCSV.Text) Then
            MessageBox.Show("Please enter a name to search for.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            ' Leer el archivo CSV línea por línea y escribir las líneas no eliminadas en un nuevo archivo temporal
            Dim tempFilePath As String = Path.GetTempFileName()
            Using reader As New StreamReader(filePathCSV)
                Using writer As New StreamWriter(tempFilePath)
                    Dim line As String
                    line = reader.ReadLine()
                    While line IsNot Nothing
                        ' Verificar si la línea actual contiene el nombre a eliminar
                        If Not line.Contains(txtSearchCSV.Text) Then
                            writer.WriteLine(line)
                        End If
                        line = reader.ReadLine()
                    End While
                End Using
            End Using

            ' Reemplazar el archivo original con el archivo temporal
            File.Delete(filePathCSV)
            File.Move(tempFilePath, filePathCSV)
            ShowCSV_InDGV()
        Catch ex As Exception
            MessageBox.Show("Error deleting line from the CSV file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "ShowContentof_JSON"
    Private Sub btnOpenJSON_Click(sender As Object, e As EventArgs) Handles btnOpenJSON.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*"
            openFileDialog.Title = "Select an JSON file"

            If openFileDialog.ShowDialog() = DialogResult.Cancel Then
                Return
            End If

            filePathJSON = openFileDialog.FileName
            LoadJSONData()
        End Using
    End Sub

    Private Sub LoadJSONData()
        Try
            Dim jsonContent As String = File.ReadAllText(filePathJSON)
            Dim jsonData As Object = JsonConvert.DeserializeObject(jsonContent)

            If jsonData IsNot Nothing Then
                ' Limpiar nodos previos en el TreeView
                tvJSON.Nodes.Clear()

                ' Agregar el JSON al TreeView
                AddNode(jsonData, "Root")
            Else
                MessageBox.Show("Empty JSON content", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading JSON data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNode(data As Object, nodeName As String, Optional parentNode As TreeNode = Nothing)
        If TypeOf data Is JObject Then
            ' Si el nodo es un objeto JSON, agregar sus propiedades como subnodos
            Dim node As TreeNode = If(parentNode IsNot Nothing, parentNode.Nodes.Add(nodeName), tvJSON.Nodes.Add(nodeName))
            For Each propertyItem As JProperty In DirectCast(data, JObject).Properties()
                AddNode(propertyItem.Value, propertyItem.Name, node)
            Next
        ElseIf TypeOf data Is JArray Then
            ' Si el nodo es un arreglo JSON, agregar sus elementos como subnodos
            Dim node As TreeNode = If(parentNode IsNot Nothing, parentNode.Nodes.Add(nodeName), tvJSON.Nodes.Add(nodeName))
            Dim index As Integer = 0
            For Each item As JToken In DirectCast(data, JArray)
                AddNode(item, "Item " & index, node)
                index += 1
            Next
        Else
            ' Si el nodo es un valor simple, agregarlo como un subnodo
            Dim node As TreeNode = If(parentNode IsNot Nothing, parentNode.Nodes.Add($"{nodeName}: {data}"), tvJSON.Nodes.Add($"{nodeName}: {data}"))
        End If
    End Sub
#End Region

#Region "ShowContentOf_XML"
    Private Sub btnOpenXML_Click(sender As Object, e As EventArgs) Handles btnOpenXML.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "XML Files|*.xml|All Files|*.*"
            openFileDialog.Title = "Select an XML file"

            If openFileDialog.ShowDialog() = DialogResult.Cancel Then
                Return
            End If

            filePathXML = openFileDialog.FileName
            LoadXMLData()
        End Using
    End Sub

    Private Sub LoadXMLData()
        Try
            ' Cargar el documento XML
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(filePathXML)

            ' Limpiar nodos previos en el TreeView
            tvXML.Nodes.Clear()

            ' Agregar el XML al TreeView
            AddXmlNode(xmlDoc.DocumentElement, "Root")
        Catch ex As Exception
            MessageBox.Show("Error loading XML data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddXmlNode(xmlNode As XmlNode, nodeName As String, Optional parentNode As TreeNode = Nothing)
        If xmlNode.NodeType = XmlNodeType.Element Then
            ' Si el nodo es un elemento XML, agregarlo como un nodo en el TreeView
            Dim node As TreeNode = If(parentNode IsNot Nothing, parentNode.Nodes.Add(nodeName), tvXML.Nodes.Add(nodeName))

            ' Agregar los atributos del elemento como subnodos
            For Each attribute As XmlAttribute In xmlNode.Attributes
                node.Nodes.Add($"@{attribute.Name}: {attribute.Value}")
            Next

            ' Agregar los nodos hijos del elemento como subnodos
            For Each childNode As XmlNode In xmlNode.ChildNodes
                AddXmlNode(childNode, childNode.Name, node)
            Next
        ElseIf xmlNode.NodeType = XmlNodeType.Text Then
            ' Si el nodo es un nodo de texto, agregarlo como un subnodo al nodo padre
            parentNode.Nodes.Add(xmlNode.Value)
        End If
    End Sub


#End Region

#Region "UnustructuredFile"
    Private Sub btnOpenTXT_Click(sender As Object, e As EventArgs) Handles btnOpenTXT.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "txt Files|*.txt|All Files|*.*"
            openFileDialog.Title = "Select an TXT file"

            If openFileDialog.ShowDialog() = DialogResult.Cancel Then
                Return
            End If

            filePathTXT = openFileDialog.FileName
        End Using

        Using sr As New StreamReader(filePathTXT)
            Dim line As String
            While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
                lstDocumentTXT.Items.Add(line)
            End While
        End Using

    End Sub

    Private Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Private Sub btnSearchTXT_Click(sender As Object, e As EventArgs) Handles btnSearchTXT.Click
        Try
            Dim palabraABuscar As String = txtSearchTXT.Text.Trim()

            lstResultados.Items.Clear()

            ' Leer el archivo línea por línea
            Using sr As New StreamReader(filePathTXT)
                Dim line As String
                Dim lineNumber As Integer = 1
                While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
                    ' Verificar si la línea contiene la palabra buscada
                    If line.Contains(palabraABuscar) Then
                        lstResultados.Items.Add($"Line {lineNumber}: {line}")
                    End If
                    lineNumber += 1
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region
End Class
