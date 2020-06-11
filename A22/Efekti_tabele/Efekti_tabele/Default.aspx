<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Efekti_tabele.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Efekti tabele</title>
    <link href="Css/index.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" action="javascript:none">
    <div>
        <table id="Tabela">
            <tr>
                <th>Rbr</th>
                <th>Ime</th>
                <th>Prezime</th>
                <th>Škola</th>
                <th>Poeni</th>
            </tr>
            
            <tr>
                <td>1.</td>
                <td>Pera</td>
                <td>Mikic</td>
                <td>OŠ “Vuk Karadžić”</td>
                <td>54</td>
            </tr>
            
            <tr>
                <td>5.</td>
                <td>Mika</td>
                <td>Zikic</td>
                <td>OŠ “Ivo Andrić”</td>
                <td>42</td>
            </tr>

            <tr>
                <td>3.</td>
                <td>Zika</td>
                <td>Mikic</td>
                <td>OŠ “Ivo Andrić”</td>
                <td>60</td>
            </tr>

            <tr>
                <td>4.</td>
                <td>Cika</td>
                <td>Mokic</td>
                <td>OŠ “Jovan Jovanovic Zmaj”</td>
                <td>30</td>
            </tr>

            <tr>
                <td>2.</td>
                <td>Pera</td>
                <td>Peric</td>
                <td>OŠ “Vuk Karadzic”</td>
                <td>51</td>
            </tr>
        </table>
        </div>

        <asp:Button ID="ButtonSortiraj" runat="server" Text="Sortiraj" style="z-index: 1; left: 247px; top: 231px; position: absolute" CssClass="dugme" />

        <asp:Button ID="ButtonOboji" runat="server" style="z-index: 1; left: 6px; top: 232px; position: absolute; right: 479px;" Text="Oboji alternativne redove" CssClass="dugme" />

        <asp:Button ID="ButtonMarkirajDa" runat="server" style="z-index: 1; left: 289px; top: 272px; position: absolute" Text="Markiraj one koji su polozili" CssClass="dugme" />

        <asp:Button ID="ButtonMarkirajNe" runat="server" style="z-index: 1; left: 23px; top: 272px; position: absolute" Text="Markiraj one koji nisu polozili" CssClass="dugme" />

        <asp:Button ID="ButtonIzdvoji" runat="server" style="z-index: 1; left: 339px; top: 230px; position: absolute" Text="Izdvoji one koji su polozili" CssClass="dugme" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

    <a href="O_aplikaciji.aspx">Informacije o autoru i aplikaciji</a>

    </form>
    <script src="Js/index.js"></script>
        
    </body>
</html>
