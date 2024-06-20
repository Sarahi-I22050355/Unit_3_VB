<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvTableCSV = New System.Windows.Forms.DataGridView()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnDeleteCSV = New System.Windows.Forms.Button()
        Me.btnSearchCSV = New System.Windows.Forms.Button()
        Me.txtSearchCSV = New System.Windows.Forms.TextBox()
        Me.btnSaveCSV = New System.Windows.Forms.Button()
        Me.btnOpenCSV = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tvJSON = New System.Windows.Forms.TreeView()
        Me.btnOpenJSON = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tvXML = New System.Windows.Forms.TreeView()
        Me.btnOpenXML = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lstDocumentTXT = New System.Windows.Forms.ListBox()
        Me.btnOpenTXT = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtSearchTXT = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnSearchTXT = New System.Windows.Forms.Button()
        Me.lstResultados = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvTableCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(966, 457)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Controls.Add(Me.dgvTableCSV)
        Me.TabPage1.Controls.Add(Me.label9)
        Me.TabPage1.Controls.Add(Me.btnDeleteCSV)
        Me.TabPage1.Controls.Add(Me.btnSearchCSV)
        Me.TabPage1.Controls.Add(Me.txtSearchCSV)
        Me.TabPage1.Controls.Add(Me.btnSaveCSV)
        Me.TabPage1.Controls.Add(Me.btnOpenCSV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(958, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CSV"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(6, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(185, 37)
        Me.label1.TabIndex = 42
        Me.label1.Text = "CSV Manager"
        '
        'dgvTableCSV
        '
        Me.dgvTableCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTableCSV.Location = New System.Drawing.Point(6, 57)
        Me.dgvTableCSV.Name = "dgvTableCSV"
        Me.dgvTableCSV.RowHeadersVisible = False
        Me.dgvTableCSV.RowHeadersWidth = 51
        Me.dgvTableCSV.Size = New System.Drawing.Size(531, 228)
        Me.dgvTableCSV.TabIndex = 41
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label9.Location = New System.Drawing.Point(543, 72)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(93, 20)
        Me.label9.TabIndex = 40
        Me.label9.Text = "Text to search"
        '
        'btnDeleteCSV
        '
        Me.btnDeleteCSV.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteCSV.Location = New System.Drawing.Point(543, 203)
        Me.btnDeleteCSV.Name = "btnDeleteCSV"
        Me.btnDeleteCSV.Size = New System.Drawing.Size(160, 46)
        Me.btnDeleteCSV.TabIndex = 39
        Me.btnDeleteCSV.Text = "Delete"
        Me.btnDeleteCSV.UseVisualStyleBackColor = True
        '
        'btnSearchCSV
        '
        Me.btnSearchCSV.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchCSV.Location = New System.Drawing.Point(543, 151)
        Me.btnSearchCSV.Name = "btnSearchCSV"
        Me.btnSearchCSV.Size = New System.Drawing.Size(160, 46)
        Me.btnSearchCSV.TabIndex = 38
        Me.btnSearchCSV.Text = "Search"
        Me.btnSearchCSV.UseVisualStyleBackColor = True
        '
        'txtSearchCSV
        '
        Me.txtSearchCSV.Location = New System.Drawing.Point(543, 99)
        Me.txtSearchCSV.Name = "txtSearchCSV"
        Me.txtSearchCSV.Size = New System.Drawing.Size(205, 27)
        Me.txtSearchCSV.TabIndex = 37
        '
        'btnSaveCSV
        '
        Me.btnSaveCSV.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveCSV.Location = New System.Drawing.Point(172, 303)
        Me.btnSaveCSV.Name = "btnSaveCSV"
        Me.btnSaveCSV.Size = New System.Drawing.Size(160, 46)
        Me.btnSaveCSV.TabIndex = 36
        Me.btnSaveCSV.Text = "Save"
        Me.btnSaveCSV.UseVisualStyleBackColor = True
        '
        'btnOpenCSV
        '
        Me.btnOpenCSV.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenCSV.Location = New System.Drawing.Point(6, 303)
        Me.btnOpenCSV.Name = "btnOpenCSV"
        Me.btnOpenCSV.Size = New System.Drawing.Size(160, 45)
        Me.btnOpenCSV.TabIndex = 35
        Me.btnOpenCSV.Text = "Open"
        Me.btnOpenCSV.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.tvJSON)
        Me.TabPage2.Controls.Add(Me.btnOpenJSON)
        Me.TabPage2.Controls.Add(Me.label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(958, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "JSON"
        '
        'tvJSON
        '
        Me.tvJSON.Location = New System.Drawing.Point(6, 73)
        Me.tvJSON.Name = "tvJSON"
        Me.tvJSON.Size = New System.Drawing.Size(756, 290)
        Me.tvJSON.TabIndex = 39
        '
        'btnOpenJSON
        '
        Me.btnOpenJSON.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenJSON.Location = New System.Drawing.Point(5, 369)
        Me.btnOpenJSON.Name = "btnOpenJSON"
        Me.btnOpenJSON.Size = New System.Drawing.Size(160, 45)
        Me.btnOpenJSON.TabIndex = 38
        Me.btnOpenJSON.Text = "Open"
        Me.btnOpenJSON.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label2.Location = New System.Drawing.Point(5, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(176, 37)
        Me.label2.TabIndex = 37
        Me.label2.Text = "JSON Viewer"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.tvXML)
        Me.TabPage3.Controls.Add(Me.btnOpenXML)
        Me.TabPage3.Controls.Add(Me.label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(958, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "XML"
        '
        'tvXML
        '
        Me.tvXML.Location = New System.Drawing.Point(4, 59)
        Me.tvXML.Name = "tvXML"
        Me.tvXML.Size = New System.Drawing.Size(756, 290)
        Me.tvXML.TabIndex = 42
        '
        'btnOpenXML
        '
        Me.btnOpenXML.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenXML.Location = New System.Drawing.Point(3, 355)
        Me.btnOpenXML.Name = "btnOpenXML"
        Me.btnOpenXML.Size = New System.Drawing.Size(160, 45)
        Me.btnOpenXML.TabIndex = 41
        Me.btnOpenXML.Text = "Open"
        Me.btnOpenXML.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label3.Location = New System.Drawing.Point(3, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(161, 37)
        Me.label3.TabIndex = 40
        Me.label3.Text = "XML Viewer"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Gray
        Me.TabPage4.Controls.Add(Me.label6)
        Me.TabPage4.Controls.Add(Me.lstDocumentTXT)
        Me.TabPage4.Controls.Add(Me.btnOpenTXT)
        Me.TabPage4.Controls.Add(Me.label5)
        Me.TabPage4.Controls.Add(Me.txtSearchTXT)
        Me.TabPage4.Controls.Add(Me.label4)
        Me.TabPage4.Controls.Add(Me.btnSearchTXT)
        Me.TabPage4.Controls.Add(Me.lstResultados)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(958, 424)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TXT"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label6.Location = New System.Drawing.Point(630, 2)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(105, 37)
        Me.label6.TabIndex = 53
        Me.label6.Text = "Results"
        '
        'lstDocumentTXT
        '
        Me.lstDocumentTXT.FormattingEnabled = True
        Me.lstDocumentTXT.ItemHeight = 20
        Me.lstDocumentTXT.Location = New System.Drawing.Point(8, 51)
        Me.lstDocumentTXT.Name = "lstDocumentTXT"
        Me.lstDocumentTXT.Size = New System.Drawing.Size(405, 284)
        Me.lstDocumentTXT.TabIndex = 52
        '
        'btnOpenTXT
        '
        Me.btnOpenTXT.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenTXT.Location = New System.Drawing.Point(8, 340)
        Me.btnOpenTXT.Name = "btnOpenTXT"
        Me.btnOpenTXT.Size = New System.Drawing.Size(160, 45)
        Me.btnOpenTXT.TabIndex = 51
        Me.btnOpenTXT.Text = "Open"
        Me.btnOpenTXT.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label5.Location = New System.Drawing.Point(8, 2)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(220, 37)
        Me.label5.TabIndex = 50
        Me.label5.Text = "TEXT Document "
        '
        'txtSearchTXT
        '
        Me.txtSearchTXT.Location = New System.Drawing.Point(419, 78)
        Me.txtSearchTXT.Name = "txtSearchTXT"
        Me.txtSearchTXT.Size = New System.Drawing.Size(205, 27)
        Me.txtSearchTXT.TabIndex = 49
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label4.Location = New System.Drawing.Point(419, 51)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(93, 20)
        Me.label4.TabIndex = 48
        Me.label4.Text = "Text to search"
        '
        'btnSearchTXT
        '
        Me.btnSearchTXT.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchTXT.Location = New System.Drawing.Point(419, 111)
        Me.btnSearchTXT.Name = "btnSearchTXT"
        Me.btnSearchTXT.Size = New System.Drawing.Size(160, 45)
        Me.btnSearchTXT.TabIndex = 47
        Me.btnSearchTXT.Text = "Search"
        Me.btnSearchTXT.UseVisualStyleBackColor = True
        '
        'lstResultados
        '
        Me.lstResultados.FormattingEnabled = True
        Me.lstResultados.ItemHeight = 20
        Me.lstResultados.Location = New System.Drawing.Point(630, 51)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(244, 284)
        Me.lstResultados.TabIndex = 46
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 456)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Unit 3 VB"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvTableCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents label1 As Label
    Private WithEvents dgvTableCSV As DataGridView
    Private WithEvents label9 As Label
    Private WithEvents btnDeleteCSV As Button
    Private WithEvents btnSearchCSV As Button
    Private WithEvents txtSearchCSV As TextBox
    Private WithEvents btnSaveCSV As Button
    Private WithEvents btnOpenCSV As Button
    Private WithEvents tvJSON As TreeView
    Private WithEvents btnOpenJSON As Button
    Private WithEvents label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Private WithEvents tvXML As TreeView
    Private WithEvents btnOpenXML As Button
    Private WithEvents label3 As Label
    Private WithEvents label6 As Label
    Private WithEvents lstDocumentTXT As ListBox
    Private WithEvents btnOpenTXT As Button
    Private WithEvents label5 As Label
    Private WithEvents txtSearchTXT As TextBox
    Private WithEvents label4 As Label
    Private WithEvents btnSearchTXT As Button
    Private WithEvents lstResultados As ListBox

End Class

