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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.displaypicturebox = New System.Windows.Forms.PictureBox()
        Me.flightpicturebox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelname = New System.Windows.Forms.Label()
        Me.labellegs = New System.Windows.Forms.Label()
        Me.labelheight = New System.Windows.Forms.Label()
        Me.bigrocketpicturebox = New System.Windows.Forms.PictureBox()
        Me.bigrocketbutton = New System.Windows.Forms.Button()
        Me.sattelitepiturebox = New System.Windows.Forms.PictureBox()
        Me.sattelitebutton = New System.Windows.Forms.Button()
        Me.voyagerpicturebox = New System.Windows.Forms.PictureBox()
        Me.voyager1button = New System.Windows.Forms.Button()
        Me.roverpicturebox = New System.Windows.Forms.PictureBox()
        Me.roverbutton = New System.Windows.Forms.Button()
        CType(Me.displaypicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flightpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bigrocketpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sattelitepiturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voyagerpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roverpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(498, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "first flight"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'displaypicturebox
        '
        Me.displaypicturebox.Image = CType(resources.GetObject("displaypicturebox.Image"), System.Drawing.Image)
        Me.displaypicturebox.Location = New System.Drawing.Point(30, -21)
        Me.displaypicturebox.Name = "displaypicturebox"
        Me.displaypicturebox.Size = New System.Drawing.Size(435, 438)
        Me.displaypicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displaypicturebox.TabIndex = 1
        Me.displaypicturebox.TabStop = False
        '
        'flightpicturebox
        '
        Me.flightpicturebox.Image = CType(resources.GetObject("flightpicturebox.Image"), System.Drawing.Image)
        Me.flightpicturebox.Location = New System.Drawing.Point(484, 51)
        Me.flightpicturebox.Name = "flightpicturebox"
        Me.flightpicturebox.Size = New System.Drawing.Size(100, 50)
        Me.flightpicturebox.TabIndex = 2
        Me.flightpicturebox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(610, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(610, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "mass:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label3.Location = New System.Drawing.Point(600, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "alltitude:"
        '
        'labelname
        '
        Me.labelname.AutoSize = True
        Me.labelname.Location = New System.Drawing.Point(661, 9)
        Me.labelname.Name = "labelname"
        Me.labelname.Size = New System.Drawing.Size(0, 16)
        Me.labelname.TabIndex = 6
        '
        'labellegs
        '
        Me.labellegs.AutoSize = True
        Me.labellegs.Location = New System.Drawing.Point(661, 45)
        Me.labellegs.Name = "labellegs"
        Me.labellegs.Size = New System.Drawing.Size(0, 16)
        Me.labellegs.TabIndex = 7
        '
        'labelheight
        '
        Me.labelheight.AutoSize = True
        Me.labelheight.Location = New System.Drawing.Point(662, 85)
        Me.labelheight.Name = "labelheight"
        Me.labelheight.Size = New System.Drawing.Size(0, 16)
        Me.labelheight.TabIndex = 8
        '
        'bigrocketpicturebox
        '
        Me.bigrocketpicturebox.Image = CType(resources.GetObject("bigrocketpicturebox.Image"), System.Drawing.Image)
        Me.bigrocketpicturebox.Location = New System.Drawing.Point(650, 200)
        Me.bigrocketpicturebox.Name = "bigrocketpicturebox"
        Me.bigrocketpicturebox.Size = New System.Drawing.Size(100, 50)
        Me.bigrocketpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.bigrocketpicturebox.TabIndex = 10
        Me.bigrocketpicturebox.TabStop = False
        '
        'bigrocketbutton
        '
        Me.bigrocketbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bigrocketbutton.Location = New System.Drawing.Point(664, 161)
        Me.bigrocketbutton.Name = "bigrocketbutton"
        Me.bigrocketbutton.Size = New System.Drawing.Size(75, 23)
        Me.bigrocketbutton.TabIndex = 9
        Me.bigrocketbutton.Text = "moon"
        Me.bigrocketbutton.UseVisualStyleBackColor = True
        '
        'sattelitepiturebox
        '
        Me.sattelitepiturebox.Image = CType(resources.GetObject("sattelitepiturebox.Image"), System.Drawing.Image)
        Me.sattelitepiturebox.Location = New System.Drawing.Point(484, 200)
        Me.sattelitepiturebox.Name = "sattelitepiturebox"
        Me.sattelitepiturebox.Size = New System.Drawing.Size(100, 50)
        Me.sattelitepiturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.sattelitepiturebox.TabIndex = 12
        Me.sattelitepiturebox.TabStop = False
        '
        'sattelitebutton
        '
        Me.sattelitebutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.sattelitebutton.Location = New System.Drawing.Point(498, 161)
        Me.sattelitebutton.Name = "sattelitebutton"
        Me.sattelitebutton.Size = New System.Drawing.Size(75, 23)
        Me.sattelitebutton.TabIndex = 11
        Me.sattelitebutton.Text = "satelite"
        Me.sattelitebutton.UseVisualStyleBackColor = True
        '
        'voyagerpicturebox
        '
        Me.voyagerpicturebox.Image = CType(resources.GetObject("voyagerpicturebox.Image"), System.Drawing.Image)
        Me.voyagerpicturebox.Location = New System.Drawing.Point(651, 367)
        Me.voyagerpicturebox.Name = "voyagerpicturebox"
        Me.voyagerpicturebox.Size = New System.Drawing.Size(100, 50)
        Me.voyagerpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.voyagerpicturebox.TabIndex = 16
        Me.voyagerpicturebox.TabStop = False
        '
        'voyager1button
        '
        Me.voyager1button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.voyager1button.Location = New System.Drawing.Point(665, 328)
        Me.voyager1button.Name = "voyager1button"
        Me.voyager1button.Size = New System.Drawing.Size(75, 23)
        Me.voyager1button.TabIndex = 15
        Me.voyager1button.Text = "voyager 1"
        Me.voyager1button.UseVisualStyleBackColor = True
        '
        'roverpicturebox
        '
        Me.roverpicturebox.Image = CType(resources.GetObject("roverpicturebox.Image"), System.Drawing.Image)
        Me.roverpicturebox.Location = New System.Drawing.Point(484, 367)
        Me.roverpicturebox.Name = "roverpicturebox"
        Me.roverpicturebox.Size = New System.Drawing.Size(100, 50)
        Me.roverpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.roverpicturebox.TabIndex = 14
        Me.roverpicturebox.TabStop = False
        '
        'roverbutton
        '
        Me.roverbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.roverbutton.Location = New System.Drawing.Point(498, 328)
        Me.roverbutton.Name = "roverbutton"
        Me.roverbutton.Size = New System.Drawing.Size(75, 23)
        Me.roverbutton.TabIndex = 13
        Me.roverbutton.Text = "rover"
        Me.roverbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.voyagerpicturebox)
        Me.Controls.Add(Me.voyager1button)
        Me.Controls.Add(Me.roverpicturebox)
        Me.Controls.Add(Me.roverbutton)
        Me.Controls.Add(Me.sattelitepiturebox)
        Me.Controls.Add(Me.sattelitebutton)
        Me.Controls.Add(Me.bigrocketpicturebox)
        Me.Controls.Add(Me.bigrocketbutton)
        Me.Controls.Add(Me.labelheight)
        Me.Controls.Add(Me.labellegs)
        Me.Controls.Add(Me.labelname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flightpicturebox)
        Me.Controls.Add(Me.displaypicturebox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "space n shit"
        CType(Me.displaypicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flightpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bigrocketpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sattelitepiturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voyagerpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roverpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents displaypicturebox As PictureBox
    Friend WithEvents flightpicturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelname As Label
    Friend WithEvents labellegs As Label
    Friend WithEvents labelheight As Label
    Friend WithEvents bigrocketpicturebox As PictureBox
    Friend WithEvents bigrocketbutton As Button
    Friend WithEvents sattelitepiturebox As PictureBox
    Friend WithEvents sattelitebutton As Button
    Friend WithEvents voyagerpicturebox As PictureBox
    Friend WithEvents voyager1button As Button
    Friend WithEvents roverpicturebox As PictureBox
    Friend WithEvents roverbutton As Button
End Class
