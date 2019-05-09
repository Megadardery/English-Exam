Public NotInheritable Class Splash


    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.ToString)
        lblCompanyName.Text = My.Application.Info.CompanyName
        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Splash_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        For counter As Double = 0.0# To 1.0# Step 0.05#
            Me.Opacity = counter
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next

        Threading.Thread.Sleep(2500)
        Me.Close()
    End Sub

    Private Sub Splash_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For counter As Double = 1.0# To 0.0# Step -0.05#
            Me.Opacity = counter
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next
        Me.Visible = False
        frmMain.Show()
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
