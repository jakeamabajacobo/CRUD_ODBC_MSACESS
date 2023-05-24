<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_itemdescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_loadrecord = New System.Windows.Forms.Button()
        Me.dg_view_item = New System.Windows.Forms.DataGridView()
        CType(Me.dg_view_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(543, 347)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(148, 36)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "DELETE ITEM"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(389, 348)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(148, 36)
        Me.btn_update.TabIndex = 37
        Me.btn_update.Text = "UPDATE ITEM"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(235, 348)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(148, 36)
        Me.btn_save.TabIndex = 36
        Me.btn_save.Text = "SAVE ITEM"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(87, 396)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Price:"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(87, 373)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(100, 20)
        Me.txt_qty.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "QTY:"
        '
        'txt_itemdescription
        '
        Me.txt_itemdescription.Location = New System.Drawing.Point(87, 349)
        Me.txt_itemdescription.Name = "txt_itemdescription"
        Me.txt_itemdescription.Size = New System.Drawing.Size(100, 20)
        Me.txt_itemdescription.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Item Description:"
        '
        'txt_itemname
        '
        Me.txt_itemname.Location = New System.Drawing.Point(87, 326)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(100, 20)
        Me.txt_itemname.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Item Name:"
        '
        'btn_loadrecord
        '
        Me.btn_loadrecord.Location = New System.Drawing.Point(600, 9)
        Me.btn_loadrecord.Name = "btn_loadrecord"
        Me.btn_loadrecord.Size = New System.Drawing.Size(121, 23)
        Me.btn_loadrecord.TabIndex = 27
        Me.btn_loadrecord.Text = "LOAD RECORD"
        Me.btn_loadrecord.UseVisualStyleBackColor = True
        '
        'dg_view_item
        '
        Me.dg_view_item.AllowUserToAddRows = False
        Me.dg_view_item.AllowUserToResizeRows = False
        Me.dg_view_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_view_item.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_view_item.Location = New System.Drawing.Point(25, 40)
        Me.dg_view_item.MultiSelect = False
        Me.dg_view_item.Name = "dg_view_item"
        Me.dg_view_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_view_item.Size = New System.Drawing.Size(696, 281)
        Me.dg_view_item.TabIndex = 26
        '
        'form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 422)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_itemdescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_itemname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_loadrecord)
        Me.Controls.Add(Me.dg_view_item)
        Me.Name = "form_main"
        Me.Text = "ODBC MSACESS"
        CType(Me.dg_view_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_itemdescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_loadrecord As Button
    Friend WithEvents dg_view_item As DataGridView
End Class
