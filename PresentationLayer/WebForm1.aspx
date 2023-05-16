<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PresentationLayer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="103px" ImageUrl="data:image/png;base64,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" />
        <asp:Label ID="Label8" CssClass="labels" runat="server" Text="UJ Staff Portal"></asp:Label>
        <div>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Identification Name"></asp:Label>
            <asp:TextBox ID="idTxtbox" runat="server" OnTextChanged="idTxtbox_TextChanged"></asp:TextBox>
            <asp:Button ID="createBtn" runat="server" OnClick="createBtn_Click" Text="Create" Width="53px" />
            
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTxtbox" runat="server"></asp:TextBox>
            <asp:Button ID="saveBtn" runat="server" OnClick="saveBtn_Click" Text="Save" Width="53px" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Surname"></asp:Label>
            <asp:TextBox ID="surnameTxtbox" runat="server"></asp:TextBox>
            <asp:Button ID="readBtn" runat="server" OnClick="readBtn_Click" Text="Read" Width="53px" />
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTxtbox" runat="server" Enabled="False"></asp:TextBox>
            <asp:Button ID="clearBtn" runat="server" Text="Clear" Width="53px" OnClick="clearBtn_Click" />
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="ageTxtbox" runat="server" Enabled="False"></asp:TextBox>
            <asp:Button ID="exitBtn" runat="server" Text="Exit" Width="53px" OnClick="exitBtn_Click" /><br/>
            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="125px" Width="718px"></asp:ListBox>
        </p>
    </form>
</body>
</html>
