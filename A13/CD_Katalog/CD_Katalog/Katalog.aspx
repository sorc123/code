<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Katalog.aspx.cs" Inherits="CD_Katalog.Katalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 54px; position: absolute; height: 19px; width: 55px" Text="Izvodjac:"></asp:Label>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 18px; top: 91px; position: absolute" Text="Naziv albuma:"></asp:Label>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 20px; top: 125px; position: absolute" Text="Zanr:"></asp:Label>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 17px; top: 164px; position: absolute" Text="Godina izdanja:"></asp:Label>
    <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 20px; top: 201px; position: absolute" Text="Izdavacka kuca:"></asp:Label>
    <asp:TextBox ID="TextBoxIzvodjac" runat="server" AutoPostBack="True" style="z-index: 1; left: 149px; top: 52px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="TextBoxNaziv" runat="server" style="z-index: 1; left: 149px; top: 88px; position: absolute"></asp:TextBox>
    <asp:DropDownList ID="DropDownListZanr" runat="server" style="z-index: 1; left: 150px; top: 126px; position: absolute">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownListGodina" runat="server" style="z-index: 1; left: 151px; top: 161px; position: absolute">
    </asp:DropDownList>
    <asp:TextBox ID="TextBoxIzdavac" runat="server" style="z-index: 1; left: 152px; top: 198px; position: absolute"></asp:TextBox>
    <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 385px; top: 92px; position: absolute; height: 133px; width: 334px" AutoGenerateColumns="False" >
        <Columns>
            <asp:ImageField DataImageUrlField="Putanja" HeaderText="Omot">
            </asp:ImageField>
            <asp:BoundField DataField="Izvodjac" HeaderText="Izvodjac" />
            <asp:BoundField DataField="Naziv" HeaderText="Naziv albuma" />
            <asp:BoundField DataField="Zanr" HeaderText="Zanr" />
            <asp:BoundField DataField="Godina" HeaderText="Godina izdanja" />
            <asp:BoundField DataField="Izdavac" HeaderText="Izdavacka kuca" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="ButtonTrazi" runat="server" OnClick="ButtonTrazi_Click" style="z-index: 1; left: 131px; top: 249px; position: absolute" Text="Trazi" />
    <asp:Label ID="LabelGreska" runat="server" CssClass="Text" style="z-index: 1; left: 319px; top: 147px; position: absolute"></asp:Label>
    </asp:Content>


