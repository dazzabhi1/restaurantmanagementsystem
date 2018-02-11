<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingRecord
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.lblBillingRecords = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvbillrecord = New System.Windows.Forms.DataGridView()
        Me.DishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kitchen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectBill = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvbillrecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(12, 449)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(158, 33)
        Me.btnDeleteInvoice.TabIndex = 1
        Me.btnDeleteInvoice.Text = "Delete Invoices"
        Me.btnDeleteInvoice.UseVisualStyleBackColor = True
        '
        'lblBillingRecords
        '
        Me.lblBillingRecords.AutoSize = True
        Me.lblBillingRecords.BackColor = System.Drawing.Color.GhostWhite
        Me.lblBillingRecords.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingRecords.ForeColor = System.Drawing.Color.Black
        Me.lblBillingRecords.Location = New System.Drawing.Point(314, 26)
        Me.lblBillingRecords.Name = "lblBillingRecords"
        Me.lblBillingRecords.Size = New System.Drawing.Size(176, 26)
        Me.lblBillingRecords.TabIndex = 2
        Me.lblBillingRecords.Text = "Biling Records"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 63)
        Me.Panel1.TabIndex = 3
        '
        'dgvbillrecord
        '
        Me.dgvbillrecord.AllowUserToAddRows = False
        Me.dgvbillrecord.AllowUserToDeleteRows = False
        Me.dgvbillrecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvbillrecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvbillrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbillrecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DishName, Me.Category, Me.Kitchen, Me.InventoryType, Me.Discount, Me.SelectBill})
        Me.dgvbillrecord.Location = New System.Drawing.Point(12, 76)
        Me.dgvbillrecord.Name = "dgvbillrecord"
        Me.dgvbillrecord.ReadOnly = True
        Me.dgvbillrecord.Size = New System.Drawing.Size(769, 367)
        Me.dgvbillrecord.TabIndex = 4
        '
        'DishName
        '
        Me.DishName.HeaderText = "DishName"
        Me.DishName.Name = "DishName"
        Me.DishName.ReadOnly = True
        Me.DishName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DishName.Width = 200
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Kitchen
        '
        Me.Kitchen.HeaderText = "Kitchen"
        Me.Kitchen.Name = "Kitchen"
        Me.Kitchen.ReadOnly = True
        '
        'InventoryType
        '
        Me.InventoryType.HeaderText = "InventoryType"
        Me.InventoryType.Name = "InventoryType"
        Me.InventoryType.ReadOnly = True
        Me.InventoryType.Width = 150
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        '
        'SelectBill
        '
        Me.SelectBill.HeaderText = "Select Bill"
        Me.SelectBill.Name = "SelectBill"
        Me.SelectBill.ReadOnly = True
        Me.SelectBill.Visible = False
        '
        'frmBillingRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(794, 488)
        Me.Controls.Add(Me.dgvbillrecord)
        Me.Controls.Add(Me.lblBillingRecords)
        Me.Controls.Add(Me.btnDeleteInvoice)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBillingRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blling Records"
        CType(Me.dgvbillrecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents lblBillingRecords As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvbillrecord As System.Windows.Forms.DataGridView
    Friend WithEvents DishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kitchen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectBill As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
