<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillling
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillling))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTableNo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBox = New System.Windows.Forms.ComboBox()
        Me.lvTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnItemNote = New System.Windows.Forms.Button()
        Me.PaymentMode = New System.Windows.Forms.GroupBox()
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbBillType = New System.Windows.Forms.ComboBox()
        Me.btnGetCash = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnBillNote = New System.Windows.Forms.Button()
        Me.btnDeleteRow = New System.Windows.Forms.Button()
        Me.btnChangeTable = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewBill = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtItemDiscount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblHDCharges = New System.Windows.Forms.Label()
        Me.lblTACharges = New System.Windows.Forms.Label()
        Me.txtHDCharges = New System.Windows.Forms.TextBox()
        Me.txtTACharges = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtServiceCharges = New System.Windows.Forms.TextBox()
        Me.txtServiceTax = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtDiscountPer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VATPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flpTables = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblKOTNo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStartBillNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtAddressLine3 = New System.Windows.Forms.TextBox()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PaymentMode.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpTables.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Table No. :"
        '
        'txtTableNo
        '
        Me.txtTableNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableNo.Location = New System.Drawing.Point(139, 20)
        Me.txtTableNo.Name = "txtTableNo"
        Me.txtTableNo.Size = New System.Drawing.Size(107, 21)
        Me.txtTableNo.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.lblDateTime)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 40)
        Me.Panel2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(267, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 29)
        Me.Label7.TabIndex = 321
        Me.Label7.Text = "Operator ID :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(421, 2)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(68, 29)
        Me.lblUser.TabIndex = 320
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(672, 2)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(127, 29)
        Me.lblDateTime.TabIndex = 319
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 29)
        Me.Label1.TabIndex = 319
        Me.Label1.Text = "Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.ForeColor = System.Drawing.Color.Black
        Me.lblBillNo.Location = New System.Drawing.Point(96, 48)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(87, 24)
        Me.lblBillNo.TabIndex = 40
        Me.lblBillNo.Text = "lblBillNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Bill No. : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbGroup)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 64)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer/Group Name"
        '
        'cmbGroup
        '
        Me.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbGroup.Enabled = False
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(12, 26)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(215, 24)
        Me.cmbGroup.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.CBox)
        Me.Panel1.Controls.Add(Me.lvTable)
        Me.Panel1.Controls.Add(Me.btnItemNote)
        Me.Panel1.Controls.Add(Me.PaymentMode)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnGetCash)
        Me.Panel1.Controls.Add(Me.btnLock)
        Me.Panel1.Controls.Add(Me.btnBillNote)
        Me.Panel1.Controls.Add(Me.btnDeleteRow)
        Me.Panel1.Controls.Add(Me.btnChangeTable)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNewBill)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.flpTables)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblBillNo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 649)
        Me.Panel1.TabIndex = 2
        '
        'CBox
        '
        Me.CBox.FormattingEnabled = True
        Me.CBox.Location = New System.Drawing.Point(894, 49)
        Me.CBox.Name = "CBox"
        Me.CBox.Size = New System.Drawing.Size(62, 21)
        Me.CBox.TabIndex = 331
        Me.CBox.Visible = False
        '
        'lvTable
        '
        Me.lvTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvTable.AutoArrange = False
        Me.lvTable.CheckBoxes = True
        Me.lvTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1})
        Me.lvTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTable.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lvTable.Location = New System.Drawing.Point(13, 283)
        Me.lvTable.Name = "lvTable"
        Me.lvTable.Size = New System.Drawing.Size(308, 357)
        Me.lvTable.TabIndex = 444
        Me.lvTable.UseCompatibleStateImageBehavior = False
        Me.lvTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Table No."
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer/Group"
        Me.ColumnHeader1.Width = 240
        '
        'btnItemNote
        '
        Me.btnItemNote.AutoSize = True
        Me.btnItemNote.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnItemNote.Enabled = False
        Me.btnItemNote.FlatAppearance.BorderSize = 0
        Me.btnItemNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemNote.ForeColor = System.Drawing.Color.White
        Me.btnItemNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnItemNote.Location = New System.Drawing.Point(1059, 592)
        Me.btnItemNote.Name = "btnItemNote"
        Me.btnItemNote.Size = New System.Drawing.Size(175, 40)
        Me.btnItemNote.TabIndex = 443
        Me.btnItemNote.Text = "Item Note         - F9"
        Me.btnItemNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemNote.UseVisualStyleBackColor = False
        '
        'PaymentMode
        '
        Me.PaymentMode.Controls.Add(Me.cmbPaymentMode)
        Me.PaymentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentMode.Location = New System.Drawing.Point(13, 214)
        Me.PaymentMode.Name = "PaymentMode"
        Me.PaymentMode.Size = New System.Drawing.Size(239, 64)
        Me.PaymentMode.TabIndex = 3
        Me.PaymentMode.TabStop = False
        Me.PaymentMode.Text = "Payment Mode"
        '
        'cmbPaymentMode
        '
        Me.cmbPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPaymentMode.Enabled = False
        Me.cmbPaymentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMode.FormattingEnabled = True
        Me.cmbPaymentMode.Items.AddRange(New Object() {"Cash", "Credit Card", "Debit Card", "Paytm", "MobiKwik", "Jio Money"})
        Me.cmbPaymentMode.Location = New System.Drawing.Point(12, 26)
        Me.cmbPaymentMode.Name = "cmbPaymentMode"
        Me.cmbPaymentMode.Size = New System.Drawing.Size(215, 24)
        Me.cmbPaymentMode.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbBillType)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill Type :"
        '
        'cmbBillType
        '
        Me.cmbBillType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBillType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBillType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBillType.FormattingEnabled = True
        Me.cmbBillType.Items.AddRange(New Object() {"KOT", "KOT Billing", "Takeaway", "Home Delivery", "Express Billing"})
        Me.cmbBillType.Location = New System.Drawing.Point(12, 26)
        Me.cmbBillType.Name = "cmbBillType"
        Me.cmbBillType.Size = New System.Drawing.Size(215, 24)
        Me.cmbBillType.TabIndex = 0
        '
        'btnGetCash
        '
        Me.btnGetCash.AutoSize = True
        Me.btnGetCash.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGetCash.FlatAppearance.BorderSize = 0
        Me.btnGetCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCash.ForeColor = System.Drawing.Color.White
        Me.btnGetCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGetCash.Location = New System.Drawing.Point(1059, 549)
        Me.btnGetCash.Name = "btnGetCash"
        Me.btnGetCash.Size = New System.Drawing.Size(182, 40)
        Me.btnGetCash.TabIndex = 439
        Me.btnGetCash.Text = "Get Cash           - F8"
        Me.btnGetCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetCash.UseVisualStyleBackColor = False
        '
        'btnLock
        '
        Me.btnLock.AutoSize = True
        Me.btnLock.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLock.FlatAppearance.BorderSize = 0
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.ForeColor = System.Drawing.Color.White
        Me.btnLock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLock.Location = New System.Drawing.Point(1061, 375)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(189, 40)
        Me.btnLock.TabIndex = 438
        Me.btnLock.Text = "Lock                    - F4"
        Me.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnBillNote
        '
        Me.btnBillNote.AutoSize = True
        Me.btnBillNote.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBillNote.FlatAppearance.BorderSize = 0
        Me.btnBillNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBillNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillNote.ForeColor = System.Drawing.Color.White
        Me.btnBillNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBillNote.Location = New System.Drawing.Point(1060, 461)
        Me.btnBillNote.Name = "btnBillNote"
        Me.btnBillNote.Size = New System.Drawing.Size(178, 40)
        Me.btnBillNote.TabIndex = 437
        Me.btnBillNote.Text = "Bill Note            - F6"
        Me.btnBillNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBillNote.UseVisualStyleBackColor = False
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.AutoSize = True
        Me.btnDeleteRow.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDeleteRow.Enabled = False
        Me.btnDeleteRow.FlatAppearance.BorderSize = 0
        Me.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRow.ForeColor = System.Drawing.Color.White
        Me.btnDeleteRow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeleteRow.Location = New System.Drawing.Point(1059, 505)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(179, 40)
        Me.btnDeleteRow.TabIndex = 436
        Me.btnDeleteRow.Text = "Delete Row       - F7"
        Me.btnDeleteRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteRow.UseVisualStyleBackColor = False
        '
        'btnChangeTable
        '
        Me.btnChangeTable.AutoSize = True
        Me.btnChangeTable.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnChangeTable.FlatAppearance.BorderSize = 0
        Me.btnChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeTable.ForeColor = System.Drawing.Color.White
        Me.btnChangeTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChangeTable.Location = New System.Drawing.Point(1061, 418)
        Me.btnChangeTable.Name = "btnChangeTable"
        Me.btnChangeTable.Size = New System.Drawing.Size(182, 40)
        Me.btnChangeTable.TabIndex = 435
        Me.btnChangeTable.Text = "Change Table    - F5"
        Me.btnChangeTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeTable.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(1061, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(186, 40)
        Me.btnCancel.TabIndex = 434
        Me.btnCancel.Text = "Cancel                - F3"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(1060, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(183, 40)
        Me.btnSave.TabIndex = 433
        Me.btnSave.Text = "Save + Print       - F2"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNewBill
        '
        Me.btnNewBill.AutoSize = True
        Me.btnNewBill.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNewBill.FlatAppearance.BorderSize = 0
        Me.btnNewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBill.ForeColor = System.Drawing.Color.White
        Me.btnNewBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewBill.Location = New System.Drawing.Point(1061, 238)
        Me.btnNewBill.Name = "btnNewBill"
        Me.btnNewBill.Size = New System.Drawing.Size(184, 40)
        Me.btnNewBill.TabIndex = 432
        Me.btnNewBill.Text = "New Bill              - F1"
        Me.btnNewBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewBill.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtItemDiscount)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtChange)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.txtCash)
        Me.Panel4.Controls.Add(Me.lblHDCharges)
        Me.Panel4.Controls.Add(Me.lblTACharges)
        Me.Panel4.Controls.Add(Me.txtHDCharges)
        Me.Panel4.Controls.Add(Me.txtTACharges)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtGrandTotal)
        Me.Panel4.Controls.Add(Me.txtServiceCharges)
        Me.Panel4.Controls.Add(Me.txtServiceTax)
        Me.Panel4.Controls.Add(Me.txtVAT)
        Me.Panel4.Controls.Add(Me.txtDiscount)
        Me.Panel4.Controls.Add(Me.txtDiscountPer)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtSubTotal)
        Me.Panel4.Location = New System.Drawing.Point(327, 462)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(639, 178)
        Me.Panel4.TabIndex = 4
        '
        'txtItemDiscount
        '
        Me.txtItemDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDiscount.Location = New System.Drawing.Point(354, 15)
        Me.txtItemDiscount.Name = "txtItemDiscount"
        Me.txtItemDiscount.ReadOnly = True
        Me.txtItemDiscount.Size = New System.Drawing.Size(107, 21)
        Me.txtItemDiscount.TabIndex = 26
        Me.txtItemDiscount.Text = "0.00"
        Me.txtItemDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(248, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 16)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Items Discount :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(454, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Change :"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(521, 146)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(107, 21)
        Me.txtChange.TabIndex = 10
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(248, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Cash :"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(337, 148)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(107, 21)
        Me.txtCash.TabIndex = 9
        Me.txtCash.Text = "0.00"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHDCharges
        '
        Me.lblHDCharges.AutoSize = True
        Me.lblHDCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHDCharges.Location = New System.Drawing.Point(248, 121)
        Me.lblHDCharges.Name = "lblHDCharges"
        Me.lblHDCharges.Size = New System.Drawing.Size(100, 16)
        Me.lblHDCharges.TabIndex = 20
        Me.lblHDCharges.Text = "HD Charges :"
        '
        'lblTACharges
        '
        Me.lblTACharges.AutoSize = True
        Me.lblTACharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTACharges.Location = New System.Drawing.Point(248, 94)
        Me.lblTACharges.Name = "lblTACharges"
        Me.lblTACharges.Size = New System.Drawing.Size(98, 16)
        Me.lblTACharges.TabIndex = 19
        Me.lblTACharges.Text = "TA Charges :"
        '
        'txtHDCharges
        '
        Me.txtHDCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDCharges.Location = New System.Drawing.Point(337, 121)
        Me.txtHDCharges.Name = "txtHDCharges"
        Me.txtHDCharges.Size = New System.Drawing.Size(107, 21)
        Me.txtHDCharges.TabIndex = 7
        Me.txtHDCharges.Text = "0.00"
        Me.txtHDCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTACharges
        '
        Me.txtTACharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTACharges.Location = New System.Drawing.Point(337, 94)
        Me.txtTACharges.Name = "txtTACharges"
        Me.txtTACharges.Size = New System.Drawing.Size(107, 21)
        Me.txtTACharges.TabIndex = 6
        Me.txtTACharges.Text = "0.00"
        Me.txtTACharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Grand Total :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Service Charges :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Service Tax :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "VAT :"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(129, 148)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(107, 21)
        Me.txtGrandTotal.TabIndex = 8
        Me.txtGrandTotal.Text = "0.00"
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServiceCharges
        '
        Me.txtServiceCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceCharges.Location = New System.Drawing.Point(129, 121)
        Me.txtServiceCharges.Name = "txtServiceCharges"
        Me.txtServiceCharges.ReadOnly = True
        Me.txtServiceCharges.Size = New System.Drawing.Size(107, 21)
        Me.txtServiceCharges.TabIndex = 5
        Me.txtServiceCharges.Text = "0.00"
        Me.txtServiceCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServiceTax
        '
        Me.txtServiceTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceTax.Location = New System.Drawing.Point(129, 94)
        Me.txtServiceTax.Name = "txtServiceTax"
        Me.txtServiceTax.ReadOnly = True
        Me.txtServiceTax.Size = New System.Drawing.Size(107, 21)
        Me.txtServiceTax.TabIndex = 4
        Me.txtServiceTax.Text = "0.00"
        Me.txtServiceTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVAT
        '
        Me.txtVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Location = New System.Drawing.Point(129, 67)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(107, 21)
        Me.txtVAT.TabIndex = 3
        Me.txtVAT.Text = "0.00"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(242, 40)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(107, 21)
        Me.txtDiscount.TabIndex = 2
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountPer
        '
        Me.txtDiscountPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountPer.Location = New System.Drawing.Point(129, 40)
        Me.txtDiscountPer.Name = "txtDiscountPer"
        Me.txtDiscountPer.ReadOnly = True
        Me.txtDiscountPer.Size = New System.Drawing.Size(107, 21)
        Me.txtDiscountPer.TabIndex = 1
        Me.txtDiscountPer.Text = "0.00"
        Me.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Bill Discount % :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sub Total :"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(129, 13)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(107, 21)
        Me.txtSubTotal.TabIndex = 0
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.Item, Me.Qty, Me.Rate, Me.Amount, Me.DiscountPer, Me.Discount, Me.VATPer, Me.VAT, Me.STPer, Me.ST, Me.SCPer, Me.SC, Me.TotalAmount, Me.Notes})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(326, 238)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.RowTemplate.Height = 18
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(728, 215)
        Me.DataGridView1.TabIndex = 393
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "Item ID"
        Me.ItemCode.Name = "ItemCode"
        '
        'Item
        '
        Me.Item.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Item.HeaderText = "Item Name"
        Me.Item.Name = "Item"
        Me.Item.Width = 200
        '
        'Qty
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle11
        Me.Qty.HeaderText = "Qty."
        Me.Qty.Name = "Qty"
        Me.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Rate
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle12
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Amount
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle13
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'DiscountPer
        '
        Me.DiscountPer.HeaderText = "Discount %"
        Me.DiscountPer.Name = "DiscountPer"
        Me.DiscountPer.Visible = False
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.Visible = False
        '
        'VATPer
        '
        Me.VATPer.HeaderText = "VAT %"
        Me.VATPer.Name = "VATPer"
        Me.VATPer.Visible = False
        '
        'VAT
        '
        Me.VAT.HeaderText = "VAT"
        Me.VAT.Name = "VAT"
        Me.VAT.Visible = False
        '
        'STPer
        '
        Me.STPer.HeaderText = "ST %"
        Me.STPer.Name = "STPer"
        Me.STPer.Visible = False
        '
        'ST
        '
        Me.ST.HeaderText = "ST"
        Me.ST.Name = "ST"
        Me.ST.Visible = False
        '
        'SCPer
        '
        Me.SCPer.HeaderText = "SC %"
        Me.SCPer.Name = "SCPer"
        Me.SCPer.Visible = False
        '
        'SC
        '
        Me.SC.HeaderText = "SC"
        Me.SC.Name = "SC"
        Me.SC.Visible = False
        '
        'TotalAmount
        '
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Visible = False
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        '
        'flpTables
        '
        Me.flpTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpTables.AutoScroll = True
        Me.flpTables.BackColor = System.Drawing.Color.White
        Me.flpTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpTables.Controls.Add(Me.txtNotes)
        Me.flpTables.Location = New System.Drawing.Point(724, 76)
        Me.flpTables.Name = "flpTables"
        Me.flpTables.Size = New System.Drawing.Size(498, 156)
        Me.flpTables.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(3, 3)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(190, 113)
        Me.txtNotes.TabIndex = 1
        Me.txtNotes.Text = ""
        Me.txtNotes.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(720, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "List of Tables :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblKOTNo)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtStartBillNo)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtContactNo)
        Me.Panel3.Controls.Add(Me.txtAddressLine3)
        Me.Panel3.Controls.Add(Me.txtAddressLine2)
        Me.Panel3.Controls.Add(Me.txtAddressLine1)
        Me.Panel3.Controls.Add(Me.txtCustomerName)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtTableNo)
        Me.Panel3.Location = New System.Drawing.Point(272, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(442, 183)
        Me.Panel3.TabIndex = 0
        '
        'lblKOTNo
        '
        Me.lblKOTNo.AutoSize = True
        Me.lblKOTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKOTNo.ForeColor = System.Drawing.Color.Black
        Me.lblKOTNo.Location = New System.Drawing.Point(280, 13)
        Me.lblKOTNo.Name = "lblKOTNo"
        Me.lblKOTNo.Size = New System.Drawing.Size(79, 24)
        Me.lblKOTNo.TabIndex = 443
        Me.lblKOTNo.Text = "KOTNo"
        Me.lblKOTNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblKOTNo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contact No. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address :"
        '
        'txtStartBillNo
        '
        Me.txtStartBillNo.Location = New System.Drawing.Point(338, 152)
        Me.txtStartBillNo.Name = "txtStartBillNo"
        Me.txtStartBillNo.Size = New System.Drawing.Size(45, 20)
        Me.txtStartBillNo.TabIndex = 442
        Me.txtStartBillNo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Customer Name :"
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(139, 152)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(154, 21)
        Me.txtContactNo.TabIndex = 5
        '
        'txtAddressLine3
        '
        Me.txtAddressLine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine3.Location = New System.Drawing.Point(139, 125)
        Me.txtAddressLine3.Name = "txtAddressLine3"
        Me.txtAddressLine3.ReadOnly = True
        Me.txtAddressLine3.Size = New System.Drawing.Size(287, 21)
        Me.txtAddressLine3.TabIndex = 4
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine2.Location = New System.Drawing.Point(139, 98)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.ReadOnly = True
        Me.txtAddressLine2.Size = New System.Drawing.Size(287, 21)
        Me.txtAddressLine2.TabIndex = 3
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine1.Location = New System.Drawing.Point(139, 71)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.ReadOnly = True
        Me.txtAddressLine1.Size = New System.Drawing.Size(287, 21)
        Me.txtAddressLine1.TabIndex = 2
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(139, 45)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(287, 21)
        Me.txtCustomerName.TabIndex = 1
        '
        'Timer2
        '
        '
        'Column1
        '
        Me.Column1.HeaderText = "Group Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Table No."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Total Amount"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "SC"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "SC %"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "ST"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "ST %"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "VAT"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "VAT %"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Discount %"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Qty."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Item Name"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewComboBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.Column1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(326, 238)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.RowHeadersWidth = 25
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.RowTemplate.Height = 18
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(728, 215)
        Me.DataGridView2.TabIndex = 445
        Me.DataGridView2.Visible = False
        '
        'frmBillling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1238, 656)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBillling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PaymentMode.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpTables.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTableNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBillNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents flpTables As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblHDCharges As System.Windows.Forms.Label
    Friend WithEvents lblTACharges As System.Windows.Forms.Label
    Friend WithEvents txtHDCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtTACharges As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceTax As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountPer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnGetCash As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnBillNote As System.Windows.Forms.Button
    Friend WithEvents btnDeleteRow As System.Windows.Forms.Button
    Friend WithEvents btnChangeTable As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNewBill As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBillType As System.Windows.Forms.ComboBox
    Friend WithEvents PaymentMode As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtStartBillNo As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents btnItemNote As System.Windows.Forms.Button
    Public WithEvents lvTable As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblKOTNo As System.Windows.Forms.Label
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VATPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
