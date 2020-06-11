<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Veb_prodavnica.aspx.cs" Inherits="Veb_prodavnica.Veb_prodavnica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 18px; top: 59px; position: absolute" Text="Proizvodjac:"></asp:Label>
<p>
</p>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 17px; top: 92px; position: absolute" Text="RAM memorija:"></asp:Label>
<asp:Label ID="Label3" runat="server" style="z-index: 1; left: 21px; top: 127px; position: absolute" Text="Procesor:"></asp:Label>
<asp:Label ID="Label4" runat="server" style="z-index: 1; left: 24px; top: 164px; position: absolute" Text="Kamera:"></asp:Label>
<asp:Label ID="Label5" runat="server" style="z-index: 1; left: 24px; top: 202px; position: absolute" Text="Ekran:"></asp:Label>
<asp:DropDownList ID="DropDownListProizvodjac" runat="server" style="z-index: 1; left: 156px; top: 52px; position: absolute">
    <asp:ListItem></asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownListRAM" runat="server" style="z-index: 1; left: 158px; top: 88px; position: absolute">
    <asp:ListItem></asp:ListItem>
    <asp:ListItem>512MB</asp:ListItem>
    <asp:ListItem>1GB</asp:ListItem>
    <asp:ListItem>1.5GB</asp:ListItem>
    <asp:ListItem>2GB</asp:ListItem>
    <asp:ListItem>3GB</asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownListProcesor" runat="server" style="z-index: 1; left: 156px; top: 125px; position: absolute">
    <asp:ListItem></asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownListKamera" runat="server" style="z-index: 1; left: 157px; top: 158px; position: absolute">
    <asp:ListItem></asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownListEkran" runat="server" style="z-index: 1; left: 156px; top: 193px; position: absolute">
    <asp:ListItem></asp:ListItem>
</asp:DropDownList>
<asp:Button ID="ButtonTrazi" runat="server" OnClick="ButtonTrazi_Click" style="z-index: 1; left: 97px; top: 255px; position: absolute; margin-bottom: 0px" Text="Trazi" />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 19px; top: 306px; position: absolute; height: 133px; width: 187px">
    <Columns>
        <asp:ImageField DataImageUrlField="Slika" HeaderText="Slika proizvoda">
        </asp:ImageField>
        <asp:BoundField DataField="Sifra" HeaderText="Sifra artikla" />
        <asp:BoundField DataField="Naziv" HeaderText="Naziv artikla" />
        <asp:BoundField DataField="Proizvodjac" HeaderText="Proizvodjac" />
        <asp:BoundField DataField="RAM" HeaderText="RAM memorija" />
        <asp:BoundField DataField="Tip" HeaderText="Tip procesora" />
        <asp:BoundField DataField="Kamera" HeaderText="Kamera" />
        <asp:BoundField DataField="Ekran" HeaderText="Ekran" />
        <asp:BoundField DataField="Cena" HeaderText="Cena" />
    </Columns>
</asp:GridView>
</asp:Content>
