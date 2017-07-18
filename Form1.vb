Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1
    Private Sub RetrieveBtn_Click(sender As Object, e As EventArgs) Handles RetrieveBtn.Click
        Dim myWebRequest As WebRequest = WebRequest.Create("https://moisescardona.me/steem/getPost/?p=" & Permlink.Text)
        Dim myWebResponse As WebResponse = myWebRequest.GetResponse()
        Dim ReceiveStream As Stream = myWebResponse.GetResponseStream()
        Dim encode As Encoding = System.Text.Encoding.GetEncoding("utf-8")
        Dim readStream As New StreamReader(ReceiveStream, encode)
        Dim PostContent As New List(Of String)
        While readStream.EndOfStream = False
            PostContent.Add(readStream.ReadLine)
        End While
        For i = 0 To PostContent.Count
            If i = 0 Then Title.Text = PostContent.Item(0)
            If i >= 2 And i < PostContent.Count - 2 Then
                PostBody.Text += PostContent.Item(i) + Environment.NewLine
            End If
            If i = PostContent.Count - 1 Then Tags.Text = PostContent.Item(i)
        Next
    End Sub
End Class
