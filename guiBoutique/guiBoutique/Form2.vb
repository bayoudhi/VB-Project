
Imports System.Data.OleDb

Public Class Form2
    Inherits System.Windows.Forms.Form
    Dim DBcnn As New OleDbConnection
    Dim dbResult As OleDbDataReader
    Dim ad As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim query As String
    Dim dbcmd As New OleDbCommand
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents Txtcolor As System.Windows.Forms.TextBox
    Friend WithEvents Txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Txtsoldout As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Dg2 As System.Windows.Forms.DataGrid
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtquantity = New System.Windows.Forms.TextBox
        Me.Txtcolor = New System.Windows.Forms.TextBox
        Me.Txtnumber = New System.Windows.Forms.TextBox
        Me.Txtname = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txtsoldout = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button6 = New System.Windows.Forms.Button
        Me.Dg2 = New System.Windows.Forms.DataGrid
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(24, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Quantiy"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(24, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Color"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(24, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Number"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Name-Type"
        '
        'Txtquantity
        '
        Me.Txtquantity.Location = New System.Drawing.Point(176, 200)
        Me.Txtquantity.Name = "Txtquantity"
        Me.Txtquantity.Size = New System.Drawing.Size(120, 20)
        Me.Txtquantity.TabIndex = 20
        Me.Txtquantity.Text = ""
        '
        'Txtcolor
        '
        Me.Txtcolor.Location = New System.Drawing.Point(176, 136)
        Me.Txtcolor.Name = "Txtcolor"
        Me.Txtcolor.Size = New System.Drawing.Size(120, 20)
        Me.Txtcolor.TabIndex = 18
        Me.Txtcolor.Text = ""
        '
        'Txtnumber
        '
        Me.Txtnumber.Location = New System.Drawing.Point(176, 104)
        Me.Txtnumber.Name = "Txtnumber"
        Me.Txtnumber.Size = New System.Drawing.Size(120, 20)
        Me.Txtnumber.TabIndex = 17
        Me.Txtnumber.Text = ""
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(176, 72)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(120, 20)
        Me.Txtname.TabIndex = 16
        Me.Txtname.Text = ""
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(24, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add out"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(24, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Sold out"
        '
        'Txtsoldout
        '
        Me.Txtsoldout.Location = New System.Drawing.Point(176, 168)
        Me.Txtsoldout.Name = "Txtsoldout"
        Me.Txtsoldout.Size = New System.Drawing.Size(120, 20)
        Me.Txtsoldout.TabIndex = 28
        Me.Txtsoldout.Text = ""
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(432, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 40)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "=>"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(472, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 40)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "recharge"
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(312, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 40)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "list"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button5.Location = New System.Drawing.Point(160, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 40)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "delete"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(312, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(568, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 40)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "exit"
        '
        'Dg2
        '
        Me.Dg2.DataMember = ""
        Me.Dg2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dg2.Location = New System.Drawing.Point(24, 256)
        Me.Dg2.Name = "Dg2"
        Me.Dg2.Size = New System.Drawing.Size(776, 296)
        Me.Dg2.TabIndex = 35
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(312, 160)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(160, 40)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "Create"
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button8.Location = New System.Drawing.Point(296, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 40)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "modify"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(976, 510)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Dg2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txtsoldout)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtquantity)
        Me.Controls.Add(Me.Txtcolor)
        Me.Controls.Add(Me.Txtnumber)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "EyeOptic-Outgoing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbCmd As OleDbCommand = New OleDbCommand
        Try
            DBcnn.ConnectionString = _
            "Provider='Microsoft.Jet.OLEDB.4.0';Data Source='STOCK.mdb'"
            DBcnn.Open()
            dbCmd.CommandText = "SELECT * FROM STOCK2"
            dbCmd.Connection = DBcnn
            dbResult = dbCmd.ExecuteReader()
            If dbResult.Read() Then
                Txtname.Text = dbResult("Name").ToString
                Txtnumber.Text = dbResult("numb").ToString
                Txtcolor.Text = dbResult("color").ToString

                Txtquantity.Text = dbResult("quantity").ToString
                Txtsoldout.Text = dbResult("soldout").ToString

            Else

                Txtname.Text = ""
                Txtnumber.Text = ""
                Txtcolor.Text = ""

                Txtquantity.Text = ""
                Txtsoldout.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x, y, z, t As Integer

        Dim cmd As OleDbCommand = New  _
            OleDbCommand("select max(id) from stock2", DBcnn)
        Dim num As Integer
        num = MsgBox("would like to create : " & Txtname.Text, MsgBoxStyle.YesNo)
        If num = vbYes Then
            dbResult.Close()
            Try
                num = cmd.ExecuteScalar + 1
            Catch
                num = 1
            End Try
            x = Val(Txtnumber.Text)
            z = Val(Txtquantity.Text)
            t = Val(Txtsoldout.Text)
            cmd.CommandText = _
             "insert into stock2 (id,name,numb,color,quantity,soldout,dateout) values (" & _
                               num.ToString & ",'" & Txtname.Text & "'," & "'" & Txtnumber.Text & "'" & ",'" & Txtcolor.Text & "'," & z & "," & t & ",'" & Today.Date & "'" & " )"
            If cmd.ExecuteNonQuery = 1 _
                 Then MsgBox("Insert ok") _
                 Else MsgBox("Pb Insert")
            cmd.CommandText = "SELECT * FROM stock2"
            dbResult = cmd.ExecuteReader()
            dbResult.Read()
            Txtname.Text = dbResult("name").ToString
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dbCmd As OleDbCommand = New  _
              OleDbCommand("SELECT * FROM stock2", DBcnn)
        Dim r As Boolean
        r = dbResult.Read()
        If r = False Then
            dbResult.Close()
            dbResult = dbCmd.ExecuteReader()
            r = dbResult.Read()
        End If
        If r = True Then
            Txtname.Text = dbResult("Name").ToString
            Txtnumber.Text = dbResult("numb").ToString
            Txtcolor.Text = dbResult("color").ToString
            Txtquantity.Text = dbResult("quantity").ToString
            Txtsoldout.Text = dbResult("soldout").ToString

        Else
            Txtname.Text = ""
            Txtnumber.Text = ""
            Txtcolor.Text = ""

            Txtquantity.Text = ""
            Txtsoldout.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        dbResult.Close()

        Try



            Dim dbCmd As OleDbCommand = New  _
                OleDbCommand("SELECT * FROM stock2", DBcnn)
            ad = New OleDbDataAdapter(dbCmd)

        Catch ex As Exception
            MsgBox("Error accessing database" & vbCrLf & ex.Message)
        End Try
        ad.Fill(ds)
        Dg2.DataSource = ds.Tables(0)

        DBcnn.Close()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dbCmd As OleDbCommand = New OleDbCommand
        Try
            DBcnn.ConnectionString = _
            "Provider='Microsoft.Jet.OLEDB.4.0';Data Source='STOCK.mdb'"
            DBcnn.Open()
            dbCmd.CommandText = "SELECT * FROM STOCK2"
            dbCmd.Connection = DBcnn
            dbResult = dbCmd.ExecuteReader()
            If dbResult.Read() Then
                Txtname.Text = dbResult("Name").ToString
                Txtnumber.Text = dbResult("numb").ToString
                Txtcolor.Text = dbResult("color").ToString
                Txtquantity.Text = dbResult("quantity").ToString
                Txtsoldout.Text = dbResult("soldout").ToString
            Else

                Txtname.Text = ""
                Txtnumber.Text = ""
                Txtcolor.Text = ""
                Txtquantity.Text = ""
                Txtsoldout.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim num As Integer
        num = MsgBox("Confirm deletion : " & Txtname.Text, MsgBoxStyle.YesNo)
        Dim cmd As OleDbCommand = New  _
           OleDbCommand("delete from stock2 where id = " & dbResult("id").ToString, DBcnn)
        If num = vbYes Then
            dbResult.Close()
            If cmd.ExecuteNonQuery = 1 _
                Then MsgBox("Item deleted") _
                Else MsgBox("Pb deletion")
            cmd.CommandText = "SELECT * FROM stock2"
            dbResult = cmd.ExecuteReader()
            If dbResult.Read() = True Then
                Txtname.Text = dbResult("Name").ToString
                Txtnumber.Text = dbResult("numb").ToString
                Txtcolor.Text = dbResult("color").ToString
                Txtquantity.Text = dbResult("quantity").ToString
                Txtsoldout.Text = dbResult("soldout").ToString
            Else
                Txtname.Text = ""
                Txtnumber.Text = ""
                Txtcolor.Text = ""
                Txtquantity.Text = ""
                Txtsoldout.Text = ""
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Close()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Txtname.Text = ""
        Txtnumber.Text = ""
        Txtcolor.Text = ""
        Txtquantity.Text = ""
        Txtsoldout.Text = ""

        Txtname.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim cmd As New OleDbCommand
        Dim n As Integer
        cmd.Connection = DBcnn
        cmd.CommandText = "update stock2 set name = '" & Txtname.Text & _
          "' where id = " & dbResult("id")
        dbResult.Close()
        n = cmd.ExecuteNonQuery
        If n = 1 Then
            MsgBox("Modify OK")
        Else
            MsgBox("Pb Modification")
        End If
        cmd.CommandText = "SELECT * FROM stock2"
        dbResult = cmd.ExecuteReader()
        dbResult.Read()
        Txtname.Text = dbResult("name").ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class


