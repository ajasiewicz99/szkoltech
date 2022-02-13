<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Wydarzenia</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <h2>Event organizer</h2>
   
            <div class="mb-3 row">
                <asp:Label ID="lblTyp" runat="server" Text="Typ" CssClass="form-control"></asp:Label>
                <asp:DropDownList ID="ddlTyp" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3 row">
                <asp:Label ID="lblMiasto" runat="server" Text="Miasto" CssClass="form-control"></asp:Label>
                <asp:DropDownList ID="ddlMiasto" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3 row">
                <asp:Label ID="lblOrganizator" runat="server" Text="Organizator" CssClass="form-control"></asp:Label>
                <asp:TextBox ID="txtOrganizator" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 row">
                <asp:Label ID="lblWydarzenie" runat="server" Text="Wydarzenie" CssClass="form-control"></asp:Label>
                <asp:TextBox ID="txtWydarzenie" runat="server"></asp:TextBox>
            </div>
            
            <div class="mb-3 row">
                <asp:Button ID="btnSave" CssClass="btn btn-primary float-end" runat="server" Text="Zapisz" OnClick="btnSave_Click" />
            </div>
            <div class="mt-3">
                <h1> Wydarzenia</h1>
                <hr />
                <asp:GridView ID="gvEvents" runat="server" CssClass="table table-dark"></asp:GridView>
            </div>
        </div>
     
    </form>
</body>
</html>
