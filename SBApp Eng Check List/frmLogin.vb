Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As String, _
    ByVal lpszDomain As String, ByVal lpszPassword As String, ByVal dwLogonType As Integer, _
    ByVal dwLogonProvider As Integer, ByRef phToken As IntPtr) As Integer
    Private Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal handle As IntPtr) As Boolean

    Private Const LOGON32_LOGON_INTERACTIVE = 2
    Private Const LOGON32_PROVIDER_DEFAULT = 0

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Search for names available'
        If Login(UsernameTextBox.Text, PasswordTextBox.Text) = True Then
            Select Case (UsernameTextBox.Text).ToUpper
                Case "BRYAN", "COEL", "ADAM.YARED", "LAWRENCE", "ANGEL", "TREVOR", "TREVOR", "JOHNNIE", "RICH"

                Case "BRYAN.IN", "COEL.SCHUMACHER", "ADAM.YARED", "LAWRENCE.GARCIA", "ANGEL.MARTINEZ", "TREVOR.PLAINE", "JOHNNIE.MORGAIN", "RICH.HALKET"

                Case Else
                    MsgBox("Access denied.", vbCritical)
                    Exit Sub
            End Select
            frmMain.Show()
            Me.Close()
        Else
            MsgBox("Invalid Username/Password. Please try again.", vbCritical)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function Login(ByVal userName As String, ByVal password As String, Optional ByVal domain As String = "") As Boolean
        If String.IsNullOrEmpty(domain) Then domain = Environment.UserDomainName
        Dim hToken As IntPtr
        If LogonUser(userName, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, hToken) Then
            If Not hToken.Equals(IntPtr.Zero) Then
                Dim newId As New Security.Principal.WindowsIdentity(hToken)
                Dim userperm As New Security.Principal.WindowsPrincipal(newId)
                If userperm.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator) Then
                    MsgBox("Hello, Admin!")
                End If
                CloseHandle(hToken)
                Return True
            End If
        End If
        Return False
    End Function

End Class
