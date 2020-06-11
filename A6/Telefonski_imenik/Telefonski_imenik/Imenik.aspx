<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Imenik.aspx.cs" Inherits="Telefonski_imenik.Imenik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 27px; top: 60px; position: absolute" Text="Ime:"></asp:Label>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 29px; top: 98px; position: absolute" Text="Prezime:"></asp:Label>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 29px; top: 131px; position: absolute" Text="Adresa:"></asp:Label>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 30px; top: 170px; position: absolute" Text="Mesto:"></asp:Label>
    <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 28px; top: 211px; position: absolute" Text="Broj telefona:"></asp:Label>
    <asp:TextBox ID="TextBoxIme" runat="server" style="z-index: 1; left: 156px; top: 56px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="TextBoxPrezime" runat="server" style="z-index: 1; left: 156px; top: 91px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="TextBoxAdresa" runat="server" style="z-index: 1; left: 158px; top: 128px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="TextBoxBrojTelefona" runat="server" style="z-index: 1; left: 156px; top: 206px; position: absolute"></asp:TextBox>
    <asp:DropDownList ID="DropDownListMesto" runat="server" style="z-index: 1; left: 159px; top: 166px; position: absolute">
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="ButtonTrazi" runat="server" OnClick="ButtonTrazi_Click" style="z-index: 1; left: 127px; top: 262px; position: absolute" Text="Trazi" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 17px; top: 321px; position: absolute; height: 133px; width: 187px">
        <Columns>
            <asp:BoundField DataField="Sifra korisnika" HeaderText="Sifra korisnika" />
            <asp:BoundField DataField="Ime" HeaderText="Ime" />
            <asp:BoundField DataField="Prezime" HeaderText="Prezime" />
            <asp:BoundField DataField="Adresa" HeaderText="Adresa" />
            <asp:BoundField DataField="Mesto" HeaderText="Mesto" />
            <asp:BoundField DataField="Broj telefona" HeaderText="Broj telefona" />
            <asp:BoundField DataField="E-mail" HeaderText="E-mail" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="LabelGreska" runat="server" style="z-index: 1; left: 388px; top: 141px; position: absolute"></asp:Label>
</asp:Content>
