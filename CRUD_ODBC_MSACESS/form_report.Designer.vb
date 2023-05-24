<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_report
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
        Me.report_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'report_viewer
        '
        Me.report_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report_viewer.LocalReport.ReportEmbeddedResource = "CRUD_ODBC_MSACESS.ReportDesinger.rdlc"
        Me.report_viewer.Location = New System.Drawing.Point(0, 0)
        Me.report_viewer.Name = "report_viewer"
        Me.report_viewer.ServerReport.BearerToken = Nothing
        Me.report_viewer.Size = New System.Drawing.Size(800, 450)
        Me.report_viewer.TabIndex = 0
        '
        'form_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.report_viewer)
        Me.Name = "form_report"
        Me.Text = "INVENTORY REPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents report_viewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
