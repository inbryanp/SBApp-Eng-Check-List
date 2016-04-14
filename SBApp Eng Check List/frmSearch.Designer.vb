<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbJobNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbQuoteNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCustomerNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEngPN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbBuild = New System.Windows.Forms.TextBox()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Job Number:"
        '
        'tbJobNumber
        '
        Me.tbJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbJobNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbJobNumber.Location = New System.Drawing.Point(80, 12)
        Me.tbJobNumber.MaxLength = 7
        Me.tbJobNumber.Name = "tbJobNumber"
        Me.tbJobNumber.Size = New System.Drawing.Size(253, 21)
        Me.tbJobNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Quote Number:"
        '
        'tbQuoteNumber
        '
        Me.tbQuoteNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuoteNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbQuoteNumber.Location = New System.Drawing.Point(438, 12)
        Me.tbQuoteNumber.MaxLength = 10
        Me.tbQuoteNumber.Name = "tbQuoteNumber"
        Me.tbQuoteNumber.Size = New System.Drawing.Size(183, 21)
        Me.tbQuoteNumber.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer Number:"
        '
        'tbCustomerNumber
        '
        Me.tbCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCustomerNumber.Location = New System.Drawing.Point(438, 39)
        Me.tbCustomerNumber.MaxLength = 5
        Me.tbCustomerNumber.Name = "tbCustomerNumber"
        Me.tbCustomerNumber.Size = New System.Drawing.Size(183, 21)
        Me.tbCustomerNumber.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer:"
        '
        'tbCustomer
        '
        Me.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCustomer.Location = New System.Drawing.Point(80, 39)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(253, 21)
        Me.tbCustomer.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(546, 93)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(390, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Eng PN:"
        '
        'tbEngPN
        '
        Me.tbEngPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEngPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEngPN.Location = New System.Drawing.Point(438, 66)
        Me.tbEngPN.MaxLength = 20
        Me.tbEngPN.Name = "tbEngPN"
        Me.tbEngPN.Size = New System.Drawing.Size(183, 21)
        Me.tbEngPN.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Build:"
        '
        'tbBuild
        '
        Me.tbBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBuild.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBuild.Location = New System.Drawing.Point(80, 66)
        Me.tbBuild.MaxLength = 50
        Me.tbBuild.Name = "tbBuild"
        Me.tbBuild.Size = New System.Drawing.Size(253, 21)
        Me.tbBuild.TabIndex = 5
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.AllowUserToAddRows = False
        Me.dgvSearchResults.AllowUserToDeleteRows = False
        Me.dgvSearchResults.AllowUserToResizeRows = False
        Me.dgvSearchResults.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(12, 122)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.ReadOnly = True
        Me.dgvSearchResults.RowHeadersVisible = False
        Me.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchResults.Size = New System.Drawing.Size(609, 503)
        Me.dgvSearchResults.TabIndex = 99
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(465, 93)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 99
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(632, 637)
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCustomerNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbQuoteNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBuild)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbEngPN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbJobNumber)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbJobNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbQuoteNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbCustomerNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbEngPN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbBuild As System.Windows.Forms.TextBox
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
