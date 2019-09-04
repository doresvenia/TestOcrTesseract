<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestOcrTesseract.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload ID="fu" runat="server" accept="image/*" />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        <hr />
        Reference:
        <a href="http://diegogiacomelli.com.br/using-tesseract4-with-csharp/">
            Using Tesseract 4 with C#
        </a>
    </form>
</body>
</html>
