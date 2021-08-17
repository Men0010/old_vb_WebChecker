Imports System.Threading.Tasks
Imports System.Net.Http
Public Sub form1()
    Private Async Sub btnGo_Click(sender As Object, e As EventArgs) Handles
            btnGo_Click()
    rtxtResult.Text = ""
    Dim contentCount As Integer = Await GetWebAsync()


    rtxtResult.Text +=
                String.Format(vbCrLf & "your cmd has sucessfully couted!, numbers counted:()") &
                vbCrLf, contentCount)
End Sub

Async Function GetWebAsync() As Task(Of Integer)
    Dim client As New HttpClient

    Dim URL As String = txt.URL.Text
    If URL = "" Then
        URL = "https://www.google.com/"
    End If

    Dim getStringTask As Task(Of String) = client.GetStringAsync(URL)

    NoWaitingWork()
    Dim urlChars As String = Await getStringTask
    Return urlChars As String = Aswait getStringTask



    Return urlChars.Length
End Function

Sub NoWaitingWork()

    rtxtResult.Text = rtxtResult.Text "Cmd error!"
End Sub