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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.bntsreport = New Guna.UI2.WinForms.Guna2Button()
        Me.bntsales = New Guna.UI2.WinForms.Guna2Button()
        Me.bntinventory = New Guna.UI2.WinForms.Guna2Button()
        Me.bntproduct = New Guna.UI2.WinForms.Guna2Button()
        Me.bntuser = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes3 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.lblstock = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblcategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.lblstocks = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvlowstocks = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Shapes4 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.bntclose = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlowstocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dashboard"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.bntsreport)
        Me.Guna2Panel1.Controls.Add(Me.bntsales)
        Me.Guna2Panel1.Controls.Add(Me.bntinventory)
        Me.Guna2Panel1.Controls.Add(Me.bntproduct)
        Me.Guna2Panel1.Controls.Add(Me.bntuser)
        Me.Guna2Panel1.Controls.Add(Me.lblDateTime)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Aqua
        Me.Guna2Panel1.Location = New System.Drawing.Point(-7, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(270, 725)
        Me.Guna2Panel1.TabIndex = 10
        '
        'bntsreport
        '
        Me.bntsreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntsreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntsreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntsreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntsreport.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntsreport.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsreport.ForeColor = System.Drawing.Color.White
        Me.bntsreport.Location = New System.Drawing.Point(19, 470)
        Me.bntsreport.Name = "bntsreport"
        Me.bntsreport.Size = New System.Drawing.Size(226, 85)
        Me.bntsreport.TabIndex = 35
        Me.bntsreport.Text = " 📊 Sales Report"
        Me.bntsreport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bntsales
        '
        Me.bntsales.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntsales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntsales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntsales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntsales.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntsales.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsales.ForeColor = System.Drawing.Color.White
        Me.bntsales.Location = New System.Drawing.Point(21, 388)
        Me.bntsales.Name = "bntsales"
        Me.bntsales.Size = New System.Drawing.Size(226, 85)
        Me.bntsales.TabIndex = 34
        Me.bntsales.Text = " 📈 Sales"
        Me.bntsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bntinventory
        '
        Me.bntinventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntinventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntinventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntinventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntinventory.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntinventory.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntinventory.ForeColor = System.Drawing.Color.White
        Me.bntinventory.Location = New System.Drawing.Point(21, 312)
        Me.bntinventory.Name = "bntinventory"
        Me.bntinventory.Size = New System.Drawing.Size(226, 85)
        Me.bntinventory.TabIndex = 33
        Me.bntinventory.Text = " 📋 Inventory"
        Me.bntinventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bntproduct
        '
        Me.bntproduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntproduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntproduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntproduct.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntproduct.ForeColor = System.Drawing.Color.White
        Me.bntproduct.Location = New System.Drawing.Point(19, 238)
        Me.bntproduct.Name = "bntproduct"
        Me.bntproduct.Size = New System.Drawing.Size(226, 85)
        Me.bntproduct.TabIndex = 32
        Me.bntproduct.Text = " ☕︎ Product"
        Me.bntproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bntuser
        '
        Me.bntuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntuser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntuser.ForeColor = System.Drawing.Color.White
        Me.bntuser.Location = New System.Drawing.Point(21, 161)
        Me.bntuser.Name = "bntuser"
        Me.bntuser.Size = New System.Drawing.Size(226, 85)
        Me.bntuser.TabIndex = 31
        Me.bntuser.Text = " 👤 User"
        Me.bntuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblDateTime
        '
        Me.lblDateTime.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(17, 656)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(325, 23)
        Me.lblDateTime.TabIndex = 11
        Me.lblDateTime.Text = "Date"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Sales_And_Inventory_System.My.Resources.Resources.logo_of_cafe
        Me.PictureBox2.Location = New System.Drawing.Point(53, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(147, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(547, 98)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0.0!
        Me.Guna2Shapes2.RoundedRadius = 40
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes2.Size = New System.Drawing.Size(242, 243)
        Me.Guna2Shapes2.TabIndex = 12
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.UseTransparentBackground = True
        Me.Guna2Shapes2.Zoom = 80
        '
        'Guna2Shapes3
        '
        Me.Guna2Shapes3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Guna2Shapes3.Location = New System.Drawing.Point(774, 101)
        Me.Guna2Shapes3.Name = "Guna2Shapes3"
        Me.Guna2Shapes3.PolygonSkip = 1
        Me.Guna2Shapes3.Rotate = 0.0!
        Me.Guna2Shapes3.RoundedRadius = 40
        Me.Guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes3.Size = New System.Drawing.Size(236, 240)
        Me.Guna2Shapes3.TabIndex = 13
        Me.Guna2Shapes3.Text = "Guna2Shapes3"
        Me.Guna2Shapes3.UseTransparentBackground = True
        Me.Guna2Shapes3.Zoom = 80
        '
        'lblstock
        '
        Me.lblstock.AutoSize = False
        Me.lblstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblstock.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.ForeColor = System.Drawing.Color.White
        Me.lblstock.Location = New System.Drawing.Point(613, 248)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(111, 40)
        Me.lblstock.TabIndex = 15
        Me.lblstock.Text = "1"
        Me.lblstock.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = False
        Me.lblcategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblcategory.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.ForeColor = System.Drawing.Color.White
        Me.lblcategory.Location = New System.Drawing.Point(839, 260)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(111, 36)
        Me.lblcategory.TabIndex = 16
        Me.lblcategory.Text = "1"
        Me.lblcategory.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(312, 89)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0.0!
        Me.Guna2Shapes1.RoundedRadius = 40
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(259, 264)
        Me.Guna2Shapes1.TabIndex = 11
        Me.Guna2Shapes1.Text = "1"
        Me.Guna2Shapes1.UseTransparentBackground = True
        Me.Guna2Shapes1.Zoom = 80
        '
        'lblstocks
        '
        Me.lblstocks.AutoSize = False
        Me.lblstocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblstocks.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstocks.ForeColor = System.Drawing.Color.White
        Me.lblstocks.Location = New System.Drawing.Point(388, 258)
        Me.lblstocks.Name = "lblstocks"
        Me.lblstocks.Size = New System.Drawing.Size(111, 45)
        Me.lblstocks.TabIndex = 20
        Me.lblstocks.Text = "1"
        Me.lblstocks.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(368, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Total Products"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(606, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Total Stocks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(823, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 22)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Total Category"
        '
        'dgvlowstocks
        '
        Me.dgvlowstocks.AllowUserToAddRows = False
        Me.dgvlowstocks.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvlowstocks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvlowstocks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlowstocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvlowstocks.ColumnHeadersHeight = 35
        Me.dgvlowstocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlowstocks.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvlowstocks.GridColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvlowstocks.Location = New System.Drawing.Point(293, 410)
        Me.dgvlowstocks.Name = "dgvlowstocks"
        Me.dgvlowstocks.ReadOnly = True
        Me.dgvlowstocks.RowHeadersVisible = False
        Me.dgvlowstocks.RowHeadersWidth = 50
        Me.dgvlowstocks.RowTemplate.Height = 24
        Me.dgvlowstocks.Size = New System.Drawing.Size(842, 251)
        Me.dgvlowstocks.TabIndex = 26
        Me.dgvlowstocks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvlowstocks.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvlowstocks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvlowstocks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvlowstocks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvlowstocks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dgvlowstocks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvlowstocks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvlowstocks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvlowstocks.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvlowstocks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvlowstocks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvlowstocks.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvlowstocks.ThemeStyle.ReadOnly = True
        Me.dgvlowstocks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvlowstocks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvlowstocks.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvlowstocks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvlowstocks.ThemeStyle.RowsStyle.Height = 24
        Me.dgvlowstocks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvlowstocks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Guna2Shapes4
        '
        Me.Guna2Shapes4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Guna2Shapes4.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Shapes4.Location = New System.Drawing.Point(173, 302)
        Me.Guna2Shapes4.Name = "Guna2Shapes4"
        Me.Guna2Shapes4.PolygonSkip = 1
        Me.Guna2Shapes4.Rotate = 0.0!
        Me.Guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes4.Size = New System.Drawing.Size(1082, 416)
        Me.Guna2Shapes4.TabIndex = 27
        Me.Guna2Shapes4.Text = "Guna2Shapes4"
        Me.Guna2Shapes4.UseTransparentBackground = True
        Me.Guna2Shapes4.Zoom = 80
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(410, 367)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(190, 34)
        Me.Guna2HtmlLabel1.TabIndex = 29
        Me.Guna2HtmlLabel1.Text = "Low Stocks"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1057, 349)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(67, 48)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "⟳"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'bntclose
        '
        Me.bntclose.Animated = True
        Me.bntclose.AutoRoundedCorners = True
        Me.bntclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntclose.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.bntclose.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntclose.Location = New System.Drawing.Point(1172, 4)
        Me.bntclose.Name = "bntclose"
        Me.bntclose.Size = New System.Drawing.Size(46, 36)
        Me.bntclose.TabIndex = 30
        Me.bntclose.Text = "x"
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox4.Image = Global.Sales_And_Inventory_System.My.Resources.Resources.image_removebg_preview__8_
        Me.Guna2PictureBox4.ImageRotate = 0.0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(322, 359)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(63, 45)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox4.TabIndex = 28
        Me.Guna2PictureBox4.TabStop = False
        Me.Guna2PictureBox4.UseTransparentBackground = True
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = Global.Sales_And_Inventory_System.My.Resources.Resources.image_removebg_preview__11_
        Me.Guna2PictureBox3.ImageRotate = 0.0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(847, 150)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(91, 63)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 21
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.Sales_And_Inventory_System.My.Resources.Resources.image_removebg_preview__9_
        Me.Guna2PictureBox2.ImageRotate = 0.0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(381, 130)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(127, 94)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 18
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Sales_And_Inventory_System.My.Resources.Resources.image_removebg_preview__10_
        Me.Guna2PictureBox1.ImageRotate = 0.0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(578, 136)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(177, 85)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(21, 541)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(226, 85)
        Me.Guna2Button2.TabIndex = 36
        Me.Guna2Button2.Text = " ➜]      Log out"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 703)
        Me.Controls.Add(Me.bntclose)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox4)
        Me.Controls.Add(Me.dgvlowstocks)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.lblstocks)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.lblcategory)
        Me.Controls.Add(Me.lblstock)
        Me.Controls.Add(Me.Guna2Shapes3)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes4)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1218, 703)
        Me.MinimumSize = New System.Drawing.Size(1218, 703)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlowstocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes3 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents lblstock As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblcategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblstocks As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvlowstocks As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Guna2Shapes4 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents bntclose As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents bntuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bntproduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bntinventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bntsales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bntsreport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button

End Class
