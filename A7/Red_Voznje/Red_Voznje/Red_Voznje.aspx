<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Red_Voznje.aspx.cs" Inherits="Red_Voznje.Red_Voznje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Autobuska linija:" style="z-index: 1; left: 22px; top: 66px; position: absolute"></asp:Label>
    <asp:DropDownList ID="DropDownListLinija" runat="server" OnSelectedIndexChanged="DropDownListLinija_SelectedIndexChanged" style="z-index: 1; left: 149px; top: 62px; position: absolute" AutoPostBack="True">
        <asp:ListItem>Izaberite liniju:</asp:ListItem>
        <asp:ListItem>Linija1</asp:ListItem>
        <asp:ListItem>Linija2</asp:ListItem>
        <asp:ListItem>Linija3</asp:ListItem>
        <asp:ListItem>Linija4</asp:ListItem>
        <asp:ListItem>Linija5</asp:ListItem>
        <asp:ListItem>Linija6</asp:ListItem>
</asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text="Smer:" style="z-index: 1; left: 24px; top: 107px; position: absolute"></asp:Label>
    <asp:DropDownList ID="DropDownListSmer" runat="server" style="z-index: 1; left: 150px; top: 102px; position: absolute"></asp:DropDownList>

<asp:Button ID="ButtonTrazi" runat="server" style="z-index: 1; left: 93px; top: 152px; position: absolute" Text="Trazi" OnClick="ButtonTrazi_Click" />
    <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 316px; top: 38px; position: absolute; height: 133px; width: 187px">
</asp:GridView>

</asp:Content>
