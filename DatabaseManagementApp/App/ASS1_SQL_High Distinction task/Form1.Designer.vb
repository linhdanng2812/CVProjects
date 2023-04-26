<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCustomer = New System.Windows.Forms.Label()
        Me.txtCustid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustAmt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProdAmt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProdname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProdid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSalesProdid = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSalesCustid = New System.Windows.Forms.TextBox()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.btnDelCust = New System.Windows.Forms.Button()
        Me.btnCustGet = New System.Windows.Forms.Button()
        Me.btnCustUpdateSales = New System.Windows.Forms.Button()
        Me.btnUpdateStatus = New System.Windows.Forms.Button()
        Me.btnCustSum = New System.Windows.Forms.Button()
        Me.btnProdUpdateSales = New System.Windows.Forms.Button()
        Me.btnProdGet = New System.Windows.Forms.Button()
        Me.btnDelProd = New System.Windows.Forms.Button()
        Me.btnAddProd = New System.Windows.Forms.Button()
        Me.btnAddSimple = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.Label()
        Me.txtProdResult = New System.Windows.Forms.Label()
        Me.btnAllProd = New System.Windows.Forms.Button()
        Me.ProdGrid = New System.Windows.Forms.DataGridView()
        Me.Prodid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prodname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sales_YTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAllCust = New System.Windows.Forms.Button()
        Me.btnAddLoc = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMaxQty = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMinqty = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLocid = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAddComplex = New System.Windows.Forms.Button()
        Me.btnAllSales = New System.Windows.Forms.Button()
        Me.btnCountSales = New System.Windows.Forms.Button()
        Me.btnDelAllSales = New System.Windows.Forms.Button()
        Me.btnDelSmallest = New System.Windows.Forms.Button()
        Me.btnDel1Cust = New System.Windows.Forms.Button()
        Me.btnDell1Prod = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.SaleGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDateNum = New System.Windows.Forms.TextBox()
        Me.txtExeResult = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnClear3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ProdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomer
        '
        Me.txtCustomer.AutoSize = True
        Me.txtCustomer.BackColor = System.Drawing.Color.PeachPuff
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(26, 36)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(175, 32)
        Me.txtCustomer.TabIndex = 0
        Me.txtCustomer.Text = "CUSTOMER"
        '
        'txtCustid
        '
        Me.txtCustid.Location = New System.Drawing.Point(179, 97)
        Me.txtCustid.Name = "txtCustid"
        Me.txtCustid.Size = New System.Drawing.Size(149, 22)
        Me.txtCustid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Name"
        '
        'txtCustname
        '
        Me.txtCustname.Location = New System.Drawing.Point(179, 137)
        Me.txtCustname.Name = "txtCustname"
        Me.txtCustname.Size = New System.Drawing.Size(149, 22)
        Me.txtCustname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(32, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(2)
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "UPDATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "New Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(179, 256)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(149, 22)
        Me.txtStatus.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Amount "
        '
        'txtCustAmt
        '
        Me.txtCustAmt.Location = New System.Drawing.Point(179, 216)
        Me.txtCustAmt.Name = "txtCustAmt"
        Me.txtCustAmt.Size = New System.Drawing.Size(149, 22)
        Me.txtCustAmt.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Amount "
        '
        'txtProdAmt
        '
        Me.txtProdAmt.Location = New System.Drawing.Point(566, 251)
        Me.txtProdAmt.Name = "txtProdAmt"
        Me.txtProdAmt.Size = New System.Drawing.Size(159, 22)
        Me.txtProdAmt.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(429, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(2)
        Me.Label8.Size = New System.Drawing.Size(87, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "UPDATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(429, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Product Name"
        '
        'txtProdname
        '
        Me.txtProdname.Location = New System.Drawing.Point(566, 135)
        Me.txtProdname.Name = "txtProdname"
        Me.txtProdname.Size = New System.Drawing.Size(159, 22)
        Me.txtProdname.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(429, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Product ID"
        '
        'txtProdid
        '
        Me.txtProdid.Location = New System.Drawing.Point(566, 95)
        Me.txtProdid.Name = "txtProdid"
        Me.txtProdid.Size = New System.Drawing.Size(159, 22)
        Me.txtProdid.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.PeachPuff
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(423, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 32)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "PRODUCT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(429, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(566, 175)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(159, 22)
        Me.txtPrice.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PeachPuff
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(807, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 32)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "SALES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(809, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(946, 175)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(144, 22)
        Me.txtQuantity.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(809, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Product ID"
        '
        'txtSalesProdid
        '
        Me.txtSalesProdid.Location = New System.Drawing.Point(946, 135)
        Me.txtSalesProdid.Name = "txtSalesProdid"
        Me.txtSalesProdid.Size = New System.Drawing.Size(144, 22)
        Me.txtSalesProdid.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(809, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 20)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Customer ID"
        '
        'txtSalesCustid
        '
        Me.txtSalesCustid.Location = New System.Drawing.Point(946, 95)
        Me.txtSalesCustid.Name = "txtSalesCustid"
        Me.txtSalesCustid.Size = New System.Drawing.Size(144, 22)
        Me.txtSalesCustid.TabIndex = 23
        '
        'btnAddCust
        '
        Me.btnAddCust.BackColor = System.Drawing.SystemColors.Info
        Me.btnAddCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddCust.Location = New System.Drawing.Point(36, 314)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(135, 35)
        Me.btnAddCust.TabIndex = 29
        Me.btnAddCust.Text = "Add"
        Me.btnAddCust.UseVisualStyleBackColor = False
        '
        'btnDelCust
        '
        Me.btnDelCust.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelCust.Location = New System.Drawing.Point(36, 439)
        Me.btnDelCust.Name = "btnDelCust"
        Me.btnDelCust.Size = New System.Drawing.Size(132, 35)
        Me.btnDelCust.TabIndex = 30
        Me.btnDelCust.Text = "Delete All"
        Me.btnDelCust.UseVisualStyleBackColor = False
        '
        'btnCustGet
        '
        Me.btnCustGet.BackColor = System.Drawing.SystemColors.Info
        Me.btnCustGet.Location = New System.Drawing.Point(36, 355)
        Me.btnCustGet.Name = "btnCustGet"
        Me.btnCustGet.Size = New System.Drawing.Size(135, 35)
        Me.btnCustGet.TabIndex = 31
        Me.btnCustGet.Text = "Get String"
        Me.btnCustGet.UseVisualStyleBackColor = False
        '
        'btnCustUpdateSales
        '
        Me.btnCustUpdateSales.BackColor = System.Drawing.SystemColors.Info
        Me.btnCustUpdateSales.Location = New System.Drawing.Point(36, 398)
        Me.btnCustUpdateSales.Name = "btnCustUpdateSales"
        Me.btnCustUpdateSales.Size = New System.Drawing.Size(135, 35)
        Me.btnCustUpdateSales.TabIndex = 32
        Me.btnCustUpdateSales.Text = "Update sales"
        Me.btnCustUpdateSales.UseVisualStyleBackColor = False
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdateStatus.Location = New System.Drawing.Point(192, 396)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(136, 35)
        Me.btnUpdateStatus.TabIndex = 33
        Me.btnUpdateStatus.Text = "Update status"
        Me.btnUpdateStatus.UseVisualStyleBackColor = False
        '
        'btnCustSum
        '
        Me.btnCustSum.BackColor = System.Drawing.SystemColors.Info
        Me.btnCustSum.Location = New System.Drawing.Point(192, 353)
        Me.btnCustSum.Name = "btnCustSum"
        Me.btnCustSum.Size = New System.Drawing.Size(136, 35)
        Me.btnCustSum.TabIndex = 34
        Me.btnCustSum.Text = "Sum Sales"
        Me.btnCustSum.UseVisualStyleBackColor = False
        '
        'btnProdUpdateSales
        '
        Me.btnProdUpdateSales.BackColor = System.Drawing.Color.Lavender
        Me.btnProdUpdateSales.Location = New System.Drawing.Point(582, 356)
        Me.btnProdUpdateSales.Name = "btnProdUpdateSales"
        Me.btnProdUpdateSales.Size = New System.Drawing.Size(143, 35)
        Me.btnProdUpdateSales.TabIndex = 38
        Me.btnProdUpdateSales.Text = "Update SalesYTD"
        Me.btnProdUpdateSales.UseVisualStyleBackColor = False
        '
        'btnProdGet
        '
        Me.btnProdGet.BackColor = System.Drawing.Color.Lavender
        Me.btnProdGet.Location = New System.Drawing.Point(433, 355)
        Me.btnProdGet.Name = "btnProdGet"
        Me.btnProdGet.Size = New System.Drawing.Size(129, 35)
        Me.btnProdGet.TabIndex = 37
        Me.btnProdGet.Text = "Get String"
        Me.btnProdGet.UseVisualStyleBackColor = False
        '
        'btnDelProd
        '
        Me.btnDelProd.BackColor = System.Drawing.Color.Lavender
        Me.btnDelProd.Location = New System.Drawing.Point(433, 396)
        Me.btnDelProd.Name = "btnDelProd"
        Me.btnDelProd.Size = New System.Drawing.Size(129, 35)
        Me.btnDelProd.TabIndex = 36
        Me.btnDelProd.Text = "Delete All"
        Me.btnDelProd.UseVisualStyleBackColor = False
        '
        'btnAddProd
        '
        Me.btnAddProd.BackColor = System.Drawing.Color.Lavender
        Me.btnAddProd.Location = New System.Drawing.Point(433, 314)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(129, 35)
        Me.btnAddProd.TabIndex = 35
        Me.btnAddProd.Text = "Add"
        Me.btnAddProd.UseVisualStyleBackColor = False
        '
        'btnAddSimple
        '
        Me.btnAddSimple.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAddSimple.Location = New System.Drawing.Point(810, 314)
        Me.btnAddSimple.Name = "btnAddSimple"
        Me.btnAddSimple.Size = New System.Drawing.Size(131, 35)
        Me.btnAddSimple.TabIndex = 39
        Me.btnAddSimple.Text = "Add Simple Sales"
        Me.btnAddSimple.UseVisualStyleBackColor = False
        '
        'txtResult
        '
        Me.txtResult.AutoSize = True
        Me.txtResult.Location = New System.Drawing.Point(33, 492)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(0, 17)
        Me.txtResult.TabIndex = 40
        '
        'txtProdResult
        '
        Me.txtProdResult.AutoSize = True
        Me.txtProdResult.BackColor = System.Drawing.Color.Lavender
        Me.txtProdResult.Location = New System.Drawing.Point(433, 406)
        Me.txtProdResult.Name = "txtProdResult"
        Me.txtProdResult.Size = New System.Drawing.Size(0, 17)
        Me.txtProdResult.TabIndex = 41
        '
        'btnAllProd
        '
        Me.btnAllProd.BackColor = System.Drawing.Color.Lavender
        Me.btnAllProd.Location = New System.Drawing.Point(580, 315)
        Me.btnAllProd.Name = "btnAllProd"
        Me.btnAllProd.Size = New System.Drawing.Size(145, 35)
        Me.btnAllProd.TabIndex = 42
        Me.btnAllProd.Text = "Get All Products"
        Me.btnAllProd.UseVisualStyleBackColor = False
        '
        'ProdGrid
        '
        Me.ProdGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Prodid, Me.Prodname, Me.Price, Me.Sales_YTD})
        Me.ProdGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ProdGrid.Location = New System.Drawing.Point(36, 656)
        Me.ProdGrid.Name = "ProdGrid"
        Me.ProdGrid.RowHeadersWidth = 25
        Me.ProdGrid.RowTemplate.Height = 24
        Me.ProdGrid.Size = New System.Drawing.Size(658, 130)
        Me.ProdGrid.TabIndex = 40
        '
        'Prodid
        '
        Me.Prodid.HeaderText = "Product ID"
        Me.Prodid.MinimumWidth = 6
        Me.Prodid.Name = "Prodid"
        Me.Prodid.Width = 125
        '
        'Prodname
        '
        Me.Prodname.HeaderText = "Product Name"
        Me.Prodname.MinimumWidth = 6
        Me.Prodname.Name = "Prodname"
        Me.Prodname.Width = 125
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.Width = 110
        '
        'Sales_YTD
        '
        Me.Sales_YTD.HeaderText = "Sales_YTD"
        Me.Sales_YTD.MinimumWidth = 6
        Me.Sales_YTD.Name = "Sales_YTD"
        Me.Sales_YTD.Width = 110
        '
        'CustGrid
        '
        Me.CustGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CustGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3})
        Me.CustGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CustGrid.Location = New System.Drawing.Point(36, 520)
        Me.CustGrid.Name = "CustGrid"
        Me.CustGrid.RowHeadersWidth = 25
        Me.CustGrid.RowTemplate.Height = 24
        Me.CustGrid.Size = New System.Drawing.Size(658, 130)
        Me.CustGrid.TabIndex = 43
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sales_YTD"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'btnAllCust
        '
        Me.btnAllCust.BackColor = System.Drawing.SystemColors.Info
        Me.btnAllCust.Location = New System.Drawing.Point(192, 312)
        Me.btnAllCust.Name = "btnAllCust"
        Me.btnAllCust.Size = New System.Drawing.Size(136, 35)
        Me.btnAllCust.TabIndex = 44
        Me.btnAllCust.Text = "Get All Customers"
        Me.btnAllCust.UseVisualStyleBackColor = False
        '
        'btnAddLoc
        '
        Me.btnAddLoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLoc.Location = New System.Drawing.Point(1221, 220)
        Me.btnAddLoc.Name = "btnAddLoc"
        Me.btnAddLoc.Size = New System.Drawing.Size(277, 35)
        Me.btnAddLoc.TabIndex = 52
        Me.btnAddLoc.Text = "Add Location"
        Me.btnAddLoc.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1217, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 20)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "MaxQty"
        '
        'txtMaxQty
        '
        Me.txtMaxQty.Location = New System.Drawing.Point(1354, 175)
        Me.txtMaxQty.Name = "txtMaxQty"
        Me.txtMaxQty.Size = New System.Drawing.Size(144, 22)
        Me.txtMaxQty.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1217, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 20)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "MinQty"
        '
        'txtMinqty
        '
        Me.txtMinqty.Location = New System.Drawing.Point(1354, 135)
        Me.txtMinqty.Name = "txtMinqty"
        Me.txtMinqty.Size = New System.Drawing.Size(144, 22)
        Me.txtMinqty.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1217, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 20)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Location ID"
        '
        'txtLocid
        '
        Me.txtLocid.Location = New System.Drawing.Point(1354, 95)
        Me.txtLocid.Name = "txtLocid"
        Me.txtLocid.Size = New System.Drawing.Size(144, 22)
        Me.txtLocid.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.PeachPuff
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1215, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 32)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "LOCATION"
        '
        'btnAddComplex
        '
        Me.btnAddComplex.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAddComplex.Location = New System.Drawing.Point(946, 314)
        Me.btnAddComplex.Name = "btnAddComplex"
        Me.btnAddComplex.Size = New System.Drawing.Size(141, 35)
        Me.btnAddComplex.TabIndex = 53
        Me.btnAddComplex.Text = "Add Complex Sales"
        Me.btnAddComplex.UseVisualStyleBackColor = False
        '
        'btnAllSales
        '
        Me.btnAllSales.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAllSales.Location = New System.Drawing.Point(810, 355)
        Me.btnAllSales.Name = "btnAllSales"
        Me.btnAllSales.Size = New System.Drawing.Size(131, 35)
        Me.btnAllSales.TabIndex = 54
        Me.btnAllSales.Text = "Get All Sales"
        Me.btnAllSales.UseVisualStyleBackColor = False
        '
        'btnCountSales
        '
        Me.btnCountSales.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCountSales.Location = New System.Drawing.Point(947, 355)
        Me.btnCountSales.Name = "btnCountSales"
        Me.btnCountSales.Size = New System.Drawing.Size(140, 35)
        Me.btnCountSales.TabIndex = 55
        Me.btnCountSales.Text = "Count Prod Sales"
        Me.btnCountSales.UseVisualStyleBackColor = False
        '
        'btnDelAllSales
        '
        Me.btnDelAllSales.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnDelAllSales.Location = New System.Drawing.Point(947, 396)
        Me.btnDelAllSales.Name = "btnDelAllSales"
        Me.btnDelAllSales.Size = New System.Drawing.Size(140, 35)
        Me.btnDelAllSales.TabIndex = 57
        Me.btnDelAllSales.Text = "Delete All"
        Me.btnDelAllSales.UseVisualStyleBackColor = False
        '
        'btnDelSmallest
        '
        Me.btnDelSmallest.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnDelSmallest.Location = New System.Drawing.Point(810, 396)
        Me.btnDelSmallest.Name = "btnDelSmallest"
        Me.btnDelSmallest.Size = New System.Drawing.Size(131, 35)
        Me.btnDelSmallest.TabIndex = 56
        Me.btnDelSmallest.Text = "Delete Smallest"
        Me.btnDelSmallest.UseVisualStyleBackColor = False
        '
        'btnDel1Cust
        '
        Me.btnDel1Cust.BackColor = System.Drawing.SystemColors.Info
        Me.btnDel1Cust.Location = New System.Drawing.Point(192, 437)
        Me.btnDel1Cust.Name = "btnDel1Cust"
        Me.btnDel1Cust.Size = New System.Drawing.Size(136, 35)
        Me.btnDel1Cust.TabIndex = 58
        Me.btnDel1Cust.Text = "Delete 1 Cust"
        Me.btnDel1Cust.UseVisualStyleBackColor = False
        '
        'btnDell1Prod
        '
        Me.btnDell1Prod.BackColor = System.Drawing.Color.Lavender
        Me.btnDell1Prod.Location = New System.Drawing.Point(582, 397)
        Me.btnDell1Prod.Name = "btnDell1Prod"
        Me.btnDell1Prod.Size = New System.Drawing.Size(143, 35)
        Me.btnDell1Prod.TabIndex = 59
        Me.btnDell1Prod.Text = "Delete 1 Prod"
        Me.btnDell1Prod.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(810, 212)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 20)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(947, 210)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(144, 22)
        Me.txtDate.TabIndex = 60
        '
        'SaleGrid
        '
        Me.SaleGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.SalesPrice, Me.SaleDate})
        Me.SaleGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SaleGrid.Location = New System.Drawing.Point(715, 656)
        Me.SaleGrid.Name = "SaleGrid"
        Me.SaleGrid.RowHeadersWidth = 25
        Me.SaleGrid.RowTemplate.Height = 24
        Me.SaleGrid.Size = New System.Drawing.Size(734, 130)
        Me.SaleGrid.TabIndex = 62
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sales ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cust ID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Prod ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'SalesPrice
        '
        Me.SalesPrice.HeaderText = "Price"
        Me.SalesPrice.MinimumWidth = 6
        Me.SalesPrice.Name = "SalesPrice"
        Me.SalesPrice.Width = 95
        '
        'SaleDate
        '
        Me.SaleDate.HeaderText = "SaleDate"
        Me.SaleDate.MinimumWidth = 6
        Me.SaleDate.Name = "SaleDate"
        Me.SaleDate.Width = 95
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label21.Location = New System.Drawing.Point(810, 249)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(2)
        Me.Label21.Size = New System.Drawing.Size(281, 24)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "COUNT THE PRODUCT SALES"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(810, 278)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(127, 20)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Number of days"
        '
        'txtDateNum
        '
        Me.txtDateNum.Location = New System.Drawing.Point(960, 276)
        Me.txtDateNum.Name = "txtDateNum"
        Me.txtDateNum.Size = New System.Drawing.Size(131, 22)
        Me.txtDateNum.TabIndex = 64
        '
        'txtExeResult
        '
        Me.txtExeResult.Location = New System.Drawing.Point(715, 520)
        Me.txtExeResult.Multiline = True
        Me.txtExeResult.Name = "txtExeResult"
        Me.txtExeResult.Size = New System.Drawing.Size(734, 126)
        Me.txtExeResult.TabIndex = 66
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Firebrick
        Me.Label23.Location = New System.Drawing.Point(715, 491)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(228, 25)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "EXECUTION RESULT"
        '
        'btnClear1
        '
        Me.btnClear1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear1.Location = New System.Drawing.Point(981, 483)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(161, 35)
        Me.btnClear1.TabIndex = 68
        Me.btnClear1.Text = "Clear Customer Table"
        Me.btnClear1.UseVisualStyleBackColor = False
        '
        'btnClear2
        '
        Me.btnClear2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear2.Location = New System.Drawing.Point(1148, 483)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(152, 35)
        Me.btnClear2.TabIndex = 69
        Me.btnClear2.Text = "Clear Product Table"
        Me.btnClear2.UseVisualStyleBackColor = False
        '
        'btnClear3
        '
        Me.btnClear3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear3.Location = New System.Drawing.Point(1306, 483)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(143, 35)
        Me.btnClear3.TabIndex = 70
        Me.btnClear3.Text = "Clear Sales Table"
        Me.btnClear3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Nirmala UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1265, 275)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 59)
        Me.TextBox1.TabIndex = 71
        Me.TextBox1.Text = "TASK 3 (Part 6-8) - High Distinction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name: Nguyen Linh Dan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Student ID: 10348855" &
    "7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1601, 798)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnClear3)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnClear1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtExeResult)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtDateNum)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.SaleGrid)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnDell1Prod)
        Me.Controls.Add(Me.btnDel1Cust)
        Me.Controls.Add(Me.btnDelAllSales)
        Me.Controls.Add(Me.btnDelSmallest)
        Me.Controls.Add(Me.btnCountSales)
        Me.Controls.Add(Me.btnAllSales)
        Me.Controls.Add(Me.btnAddComplex)
        Me.Controls.Add(Me.btnAddLoc)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMaxQty)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtMinqty)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtLocid)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnAllCust)
        Me.Controls.Add(Me.CustGrid)
        Me.Controls.Add(Me.ProdGrid)
        Me.Controls.Add(Me.btnAllProd)
        Me.Controls.Add(Me.txtProdResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnAddSimple)
        Me.Controls.Add(Me.btnProdUpdateSales)
        Me.Controls.Add(Me.btnProdGet)
        Me.Controls.Add(Me.btnDelProd)
        Me.Controls.Add(Me.btnAddProd)
        Me.Controls.Add(Me.btnCustSum)
        Me.Controls.Add(Me.btnUpdateStatus)
        Me.Controls.Add(Me.btnCustUpdateSales)
        Me.Controls.Add(Me.btnCustGet)
        Me.Controls.Add(Me.btnDelCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSalesProdid)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSalesCustid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProdAmt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtProdname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtProdid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCustAmt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustid)
        Me.Controls.Add(Me.txtCustomer)
        Me.Name = "Form1"
        Me.Text = "SQL Pass Task 1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomer As Label
    Friend WithEvents txtCustid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustAmt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProdAmt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProdname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProdid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSalesProdid As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSalesCustid As TextBox
    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnDelCust As Button
    Friend WithEvents btnCustGet As Button
    Friend WithEvents btnCustUpdateSales As Button
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnCustSum As Button
    Friend WithEvents btnProdUpdateSales As Button
    Friend WithEvents btnProdGet As Button
    Friend WithEvents btnDelProd As Button
    Friend WithEvents btnAddProd As Button
    Friend WithEvents btnAddSimple As Button
    Friend WithEvents txtResult As Label
    Friend WithEvents txtProdResult As Label
    Friend WithEvents btnAllProd As Button
    Friend WithEvents ProdGrid As DataGridView
    Friend WithEvents CustGrid As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnAllCust As Button
    Friend WithEvents btnAddLoc As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMaxQty As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMinqty As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtLocid As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnAddComplex As Button
    Friend WithEvents btnAllSales As Button
    Friend WithEvents btnCountSales As Button
    Friend WithEvents btnDelAllSales As Button
    Friend WithEvents btnDelSmallest As Button
    Friend WithEvents btnDel1Cust As Button
    Friend WithEvents btnDell1Prod As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Prodid As DataGridViewTextBoxColumn
    Friend WithEvents Prodname As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Sales_YTD As DataGridViewTextBoxColumn
    Friend WithEvents SaleGrid As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents SalesPrice As DataGridViewTextBoxColumn
    Friend WithEvents SaleDate As DataGridViewTextBoxColumn
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDateNum As TextBox
    Friend WithEvents txtExeResult As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnClear1 As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnClear3 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
