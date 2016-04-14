<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Combiner"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Recombiner"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"String Inverter"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Power Supply"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Wire"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Parts"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.rtbComments = New System.Windows.Forms.RichTextBox()
        Me.tbEngPN = New System.Windows.Forms.TextBox()
        Me.tbBuild = New System.Windows.Forms.TextBox()
        Me.tbSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbLineItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvJobDocs = New System.Windows.Forms.DataGridView()
        Me.btnSearchJob = New System.Windows.Forms.Button()
        Me.btnUpdateSerial = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.tbJobNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineeringCheckListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ETLGeneratorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvLinkedDocs = New System.Windows.Forms.DataGridView()
        Me.dgvTaskList = New System.Windows.Forms.DataGridView()
        Me.btnUpdateGrid = New System.Windows.Forms.Button()
        Me.lstViewWO = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbInquiry = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSales = New System.Windows.Forms.TextBox()
        Me.cbLookFor = New System.Windows.Forms.ComboBox()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstVCriteria = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbQty = New System.Windows.Forms.TextBox()
        CType(Me.dgvJobDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvLinkedDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbComments
        '
        Me.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbComments.Location = New System.Drawing.Point(95, 137)
        Me.rtbComments.Name = "rtbComments"
        Me.rtbComments.ReadOnly = True
        Me.rtbComments.Size = New System.Drawing.Size(245, 152)
        Me.rtbComments.TabIndex = 99
        Me.rtbComments.Text = ""
        '
        'tbEngPN
        '
        Me.tbEngPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEngPN.Location = New System.Drawing.Point(95, 88)
        Me.tbEngPN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbEngPN.Name = "tbEngPN"
        Me.tbEngPN.ReadOnly = True
        Me.tbEngPN.Size = New System.Drawing.Size(245, 20)
        Me.tbEngPN.TabIndex = 99
        '
        'tbBuild
        '
        Me.tbBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBuild.Location = New System.Drawing.Point(95, 61)
        Me.tbBuild.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbBuild.Name = "tbBuild"
        Me.tbBuild.ReadOnly = True
        Me.tbBuild.Size = New System.Drawing.Size(441, 20)
        Me.tbBuild.TabIndex = 99
        '
        'tbSerialNumber
        '
        Me.tbSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSerialNumber.Location = New System.Drawing.Point(94, 294)
        Me.tbSerialNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSerialNumber.MaxLength = 25
        Me.tbSerialNumber.Name = "tbSerialNumber"
        Me.tbSerialNumber.Size = New System.Drawing.Size(142, 20)
        Me.tbSerialNumber.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 14)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Eng PN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Comments:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Build:"
        '
        'tbLineItem
        '
        Me.tbLineItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbLineItem.Location = New System.Drawing.Point(306, 33)
        Me.tbLineItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbLineItem.MaxLength = 3
        Me.tbLineItem.Name = "tbLineItem"
        Me.tbLineItem.Size = New System.Drawing.Size(84, 20)
        Me.tbLineItem.TabIndex = 1
        Me.tbLineItem.Text = "000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Serial Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Line Item:"
        '
        'dgvJobDocs
        '
        Me.dgvJobDocs.AllowUserToAddRows = False
        Me.dgvJobDocs.AllowUserToDeleteRows = False
        Me.dgvJobDocs.AllowUserToResizeRows = False
        Me.dgvJobDocs.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvJobDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobDocs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJobDocs.Location = New System.Drawing.Point(3, 3)
        Me.dgvJobDocs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvJobDocs.Name = "dgvJobDocs"
        Me.dgvJobDocs.ReadOnly = True
        Me.dgvJobDocs.RowHeadersVisible = False
        Me.dgvJobDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJobDocs.Size = New System.Drawing.Size(510, 205)
        Me.dgvJobDocs.TabIndex = 15
        '
        'btnSearchJob
        '
        Me.btnSearchJob.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearchJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchJob.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchJob.Location = New System.Drawing.Point(396, 32)
        Me.btnSearchJob.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchJob.Name = "btnSearchJob"
        Me.btnSearchJob.Size = New System.Drawing.Size(140, 22)
        Me.btnSearchJob.TabIndex = 3
        Me.btnSearchJob.Text = "Search"
        Me.btnSearchJob.UseVisualStyleBackColor = False
        '
        'btnUpdateSerial
        '
        Me.btnUpdateSerial.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSerial.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSerial.Location = New System.Drawing.Point(247, 293)
        Me.btnUpdateSerial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateSerial.Name = "btnUpdateSerial"
        Me.btnUpdateSerial.Size = New System.Drawing.Size(93, 22)
        Me.btnUpdateSerial.TabIndex = 5
        Me.btnUpdateSerial.Text = "Update Serial Number"
        Me.btnUpdateSerial.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(395, 564)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(143, 22)
        Me.btnOpen.TabIndex = 8
        Me.btnOpen.Text = "Open Selected Documents"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'tbJobNumber
        '
        Me.tbJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbJobNumber.Location = New System.Drawing.Point(95, 33)
        Me.tbJobNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbJobNumber.MaxLength = 7
        Me.tbJobNumber.Name = "tbJobNumber"
        Me.tbJobNumber.Size = New System.Drawing.Size(141, 20)
        Me.tbJobNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Job Number:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.DocumentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1141, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EngineeringCheckListToolStripMenuItem, Me.ETLGeneratorsToolStripMenuItem})
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'EngineeringCheckListToolStripMenuItem
        '
        Me.EngineeringCheckListToolStripMenuItem.Name = "EngineeringCheckListToolStripMenuItem"
        Me.EngineeringCheckListToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EngineeringCheckListToolStripMenuItem.Text = "Engineering Check List"
        '
        'ETLGeneratorsToolStripMenuItem
        '
        Me.ETLGeneratorsToolStripMenuItem.Name = "ETLGeneratorsToolStripMenuItem"
        Me.ETLGeneratorsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ETLGeneratorsToolStripMenuItem.Text = "ETL Generators"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 322)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(524, 237)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvJobDocs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(516, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Job Documents"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvLinkedDocs)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(516, 211)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Linked Documents"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvLinkedDocs
        '
        Me.dgvLinkedDocs.AllowUserToAddRows = False
        Me.dgvLinkedDocs.AllowUserToDeleteRows = False
        Me.dgvLinkedDocs.AllowUserToResizeRows = False
        Me.dgvLinkedDocs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLinkedDocs.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvLinkedDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLinkedDocs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLinkedDocs.Location = New System.Drawing.Point(3, 3)
        Me.dgvLinkedDocs.Name = "dgvLinkedDocs"
        Me.dgvLinkedDocs.ReadOnly = True
        Me.dgvLinkedDocs.RowHeadersVisible = False
        Me.dgvLinkedDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLinkedDocs.Size = New System.Drawing.Size(510, 205)
        Me.dgvLinkedDocs.TabIndex = 28
        '
        'dgvTaskList
        '
        Me.dgvTaskList.AllowUserToAddRows = False
        Me.dgvTaskList.AllowUserToDeleteRows = False
        Me.dgvTaskList.AllowUserToResizeRows = False
        Me.dgvTaskList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTaskList.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskList.Location = New System.Drawing.Point(542, 112)
        Me.dgvTaskList.Name = "dgvTaskList"
        Me.dgvTaskList.ReadOnly = True
        Me.dgvTaskList.RowHeadersVisible = False
        Me.dgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTaskList.Size = New System.Drawing.Size(587, 473)
        Me.dgvTaskList.TabIndex = 28
        '
        'btnUpdateGrid
        '
        Me.btnUpdateGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateGrid.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateGrid.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateGrid.Location = New System.Drawing.Point(1046, 82)
        Me.btnUpdateGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateGrid.Name = "btnUpdateGrid"
        Me.btnUpdateGrid.Size = New System.Drawing.Size(83, 22)
        Me.btnUpdateGrid.TabIndex = 12
        Me.btnUpdateGrid.Text = "Update"
        Me.btnUpdateGrid.UseVisualStyleBackColor = False
        '
        'lstViewWO
        '
        Me.lstViewWO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstViewWO.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstViewWO.GridLines = True
        Me.lstViewWO.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstViewWO.Location = New System.Drawing.Point(396, 137)
        Me.lstViewWO.MultiSelect = False
        Me.lstViewWO.Name = "lstViewWO"
        Me.lstViewWO.ShowGroups = False
        Me.lstViewWO.Size = New System.Drawing.Size(140, 152)
        Me.lstViewWO.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstViewWO.TabIndex = 99
        Me.lstViewWO.UseCompatibleStateImageBehavior = False
        Me.lstViewWO.View = System.Windows.Forms.View.List
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 564)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 22)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print Line Items"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(125, 564)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 22)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Print Specifications"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tbInquiry
        '
        Me.tbInquiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInquiry.Location = New System.Drawing.Point(395, 88)
        Me.tbInquiry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbInquiry.MaxLength = 3
        Me.tbInquiry.Name = "tbInquiry"
        Me.tbInquiry.ReadOnly = True
        Me.tbInquiry.Size = New System.Drawing.Size(143, 20)
        Me.tbInquiry.TabIndex = 1
        Me.tbInquiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Inquiry:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Customer:"
        '
        'tbCustomer
        '
        Me.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCustomer.Location = New System.Drawing.Point(95, 112)
        Me.tbCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.ReadOnly = True
        Me.tbCustomer.Size = New System.Drawing.Size(245, 20)
        Me.tbCustomer.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(354, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Sales:"
        '
        'tbSales
        '
        Me.tbSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSales.Location = New System.Drawing.Point(395, 112)
        Me.tbSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSales.MaxLength = 3
        Me.tbSales.Name = "tbSales"
        Me.tbSales.ReadOnly = True
        Me.tbSales.Size = New System.Drawing.Size(143, 20)
        Me.tbSales.TabIndex = 1
        Me.tbSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbLookFor
        '
        Me.cbLookFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLookFor.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLookFor.FormattingEnabled = True
        Me.cbLookFor.Items.AddRange(New Object() {"Unreleased", "Released"})
        Me.cbLookFor.Location = New System.Drawing.Point(542, 33)
        Me.cbLookFor.Name = "cbLookFor"
        Me.cbLookFor.Size = New System.Drawing.Size(182, 21)
        Me.cbLookFor.TabIndex = 100
        Me.cbLookFor.Text = "Unreleased"
        '
        'DTPFrom
        '
        Me.DTPFrom.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFrom.Location = New System.Drawing.Point(584, 59)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(140, 20)
        Me.DTPFrom.TabIndex = 101
        Me.DTPFrom.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'DTPTo
        '
        Me.DTPTo.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTo.Location = New System.Drawing.Point(584, 86)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(140, 20)
        Me.DTPTo.TabIndex = 101
        Me.DTPTo.Value = New Date(2016, 12, 31, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(542, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 14)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "From:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(557, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 14)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "To:"
        '
        'lstVCriteria
        '
        Me.lstVCriteria.BackColor = System.Drawing.Color.LightSlateGray
        Me.lstVCriteria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstVCriteria.CheckBoxes = True
        Me.lstVCriteria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        ListViewItem1.Checked = True
        ListViewItem1.StateImageIndex = 1
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.Checked = True
        ListViewItem2.StateImageIndex = 1
        ListViewItem2.UseItemStyleForSubItems = False
        ListViewItem3.Checked = True
        ListViewItem3.StateImageIndex = 1
        ListViewItem3.UseItemStyleForSubItems = False
        ListViewItem4.Checked = True
        ListViewItem4.StateImageIndex = 1
        ListViewItem4.UseItemStyleForSubItems = False
        ListViewItem5.Checked = True
        ListViewItem5.StateImageIndex = 1
        ListViewItem5.UseItemStyleForSubItems = False
        ListViewItem6.Checked = True
        ListViewItem6.StateImageIndex = 1
        ListViewItem6.UseItemStyleForSubItems = False
        Me.lstVCriteria.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lstVCriteria.Location = New System.Drawing.Point(730, 33)
        Me.lstVCriteria.Name = "lstVCriteria"
        Me.lstVCriteria.Size = New System.Drawing.Size(327, 73)
        Me.lstVCriteria.TabIndex = 104
        Me.lstVCriteria.UseCompatibleStateImageBehavior = False
        Me.lstVCriteria.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(362, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 14)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Qty:"
        '
        'tbQty
        '
        Me.tbQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQty.Location = New System.Drawing.Point(395, 293)
        Me.tbQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbQty.MaxLength = 3
        Me.tbQty.Name = "tbQty"
        Me.tbQty.ReadOnly = True
        Me.tbQty.Size = New System.Drawing.Size(143, 20)
        Me.tbQty.TabIndex = 1
        Me.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1141, 597)
        Me.Controls.Add(Me.btnUpdateGrid)
        Me.Controls.Add(Me.lstVCriteria)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DTPTo)
        Me.Controls.Add(Me.DTPFrom)
        Me.Controls.Add(Me.cbLookFor)
        Me.Controls.Add(Me.lstViewWO)
        Me.Controls.Add(Me.dgvTaskList)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.rtbComments)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.tbEngPN)
        Me.Controls.Add(Me.tbBuild)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbSerialNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.tbSales)
        Me.Controls.Add(Me.tbInquiry)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbLineItem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearchJob)
        Me.Controls.Add(Me.btnUpdateSerial)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.tbJobNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MinimumSize = New System.Drawing.Size(1085, 635)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SBApp Engineering Check"
        CType(Me.dgvJobDocs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvLinkedDocs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbComments As System.Windows.Forms.RichTextBox
    Friend WithEvents tbEngPN As System.Windows.Forms.TextBox
    Friend WithEvents tbBuild As System.Windows.Forms.TextBox
    Friend WithEvents tbSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbLineItem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvJobDocs As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchJob As System.Windows.Forms.Button
    Friend WithEvents btnUpdateSerial As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents tbJobNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DocumentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EngineeringCheckListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ETLGeneratorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvLinkedDocs As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTaskList As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateGrid As System.Windows.Forms.Button
    Friend WithEvents lstViewWO As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbInquiry As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbSales As System.Windows.Forms.TextBox
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbLookFor As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lstVCriteria As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbQty As System.Windows.Forms.TextBox

End Class
