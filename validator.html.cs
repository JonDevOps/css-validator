<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="cs" lang="cs" dir="ltr">
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta http-equiv="Content-Script-Type" content="text/javascript" />
    <meta http-equiv="Content-Style-Type" content="text/css" />
    <title>Validační služba W3C CSS</title>
    <link rev="made" href="mailto:www-validator-css@w3.org" />
    <link rev="start" href="./" title="Domácí stránka validační služby W3C CSS " />
    <style type="text/css" media="all">
      @import "style/base.css";
	      </style>   
      <script type="text/javascript" src="scripts/mootools.js"></script>
    <script type="text/javascript" src="scripts/w3c-validator.js"></script>
    </head>

  <body>
   <div id="banner">
    <h1 id="title"><a href="http://www.w3.org/"><img alt="W3C" width="110" height="61" id="logo" src="./images/w3c.png" /></a>
    <a href="./"><span>CSS Validation Service</span></a></h1>
    <p id="tagline">
      Zkontrolovat tabulky kaskádových stylů (CSS) a dokumenty  (X)HTML s tabulkami stylů.
    </p>
   </div>
  <div id="frontforms">
      <ul id="tabset_tabs">
        <li><a href="#validate-by-uri" class="active">Podle URl</a></li><li><a href="#validate-by-upload">Nahráním souboru</a></li><li><a href="#validate-by-input">Přímým vstupem</a></li>
      </ul>
      <div id="fields">

      <fieldset id="validate-by-uri" class="tabset_content front">
        <legend class="tabset_label">Ověřením URI</legend>
        <form method="get" action="validator">
        <p class="instructions">
          Zadejte URI dokumentu (HTML pouze s CSS nebo CSS), který chcete ověřit.:
        </p>
        <p>
           <label title="Adresa stránky k ověření" for="uri">Adresa:
             <input type="text" name="uri" id="uri" size="45" />
           </label>
        </p>
              <fieldset id="extra_opt_uri" class="moreoptions">
    <legend class="toggletext" title="Zobrazit/Skrýt další možnosti ověření">Další možnosti</legend>
    <div class="options">
    <table>
    <tr>
    <th id="header_profile_uri">
      <label for="profile_uri">Profil:</label>
    </th>
    <td headers="header_profile_uri">
      <select id="profile_uri" name="profile">
        <option value="none">Žádný zvláštní profil</option>
        <option value="css1">CSS Úroveň 1</option>
        <option value="css2">CSS Úroveň 2</option>
        <option value="css21">CSS Úroveň 2.1</option>
        <option value="css3">CSS Úroveň 3</option>
        <option selected="selected" value="css3svg">CSS Úroveň 3 + SVG</option>
        <option value="svg">SVG</option>
        <option value="svgbasic">SVG základní</option>
        <option value="svgtiny">SVG malý</option>  
        <option value="mobile">Mobil</option>
        <option value="atsc-tv">ATSC TV profil</option>
        <option value="tv">TV profil</option>
      </select>
    </td>
    <th id="header_medium_uri">
      <label for="medium_uri">Střední:</label>
    </th>
    <td headers="header_medium_uri">
      <select id="medium_uri" name="usermedium">
        <option selected="selected" value="all">Vše</option>
        <option value="aural">zvukový</option>
        <option value="braille">braillovo</option>
        <option value="embossed">vypouklý</option>
        <option value="handheld">do ruky</option>
        <option value="print">tisk</option>
        <option value= "projection">projekce</option>
        <option value="screen">obrazovka</option>
        <option value="tty">TTY</option>
        <option value="tv">TV</option>
        <option value="presentation">prezentace</option>
      </select>
    </td>
    </tr>
    <tr>
        <th id="header_warning_uri">
      <label for="warning_uri">Varování:</label>
    </th>
    <td
        colspan="1"
         headers="header_warning_uri">
      <select id="warning_uri" name="warning"> 
        <option value="2">Vše</option>
        <option selected="selected" value="1">Normální zpráva</option>
        <option value="0">Nejdůležitější</option>
        <option value="no">Žádné varování</option>
      </select>
    </td>

    <th id="header_vext_warning_uri">
      <label id="vext_warning_input">Vendor Extensions:</label>     
    </th>
    <td headers="header_vext_warning_uri">
      <select id="vext_warning_uri" name="vextwarning">
        <option value="">Default</option>
        <option value="true">Warnings</option>
        <option value="false">Errors</option>
      </select>
    </td>

    </tr>
    </table>
    </div><!-- item_contents -->
  </fieldset><!-- invisible -->
  
  <p class="submit_button">
  <input type="hidden" name="lang" value="cs" />
    <label title="Potvrďte URI pro ověření">
      <input type="submit" value="Zkontrolovat" />
    </label>
  </p>
      </form>
      </fieldset>

      <fieldset id="validate-by-upload"  class="tabset_content front">
        <legend class="tabset_label">Ověřit po nahrání souboru</legend>
      <form method="post" enctype="multipart/form-data" action="validator">
        <p class="instructions">Vyberte dokument, který chcete ověřit:</p>
        <p>
          <label title="Vyberte soubor k nahrání a ověření" for="file">Místní soubor CSS:
          <input type="file" id="file" name="file" size="30" /></label></p>
                      <fieldset id="extra_opt_upload" class="moreoptions">
    <legend class="toggletext" title="Zobrazit/Skrýt další možnosti ověření">Další možnosti</legend>
    <div class="options">
    <table>
    <tr>
    <th id="header_profile_upload">
      <label for="profile_upload">Profil:</label>
    </th>
    <td headers="header_profile_upload">
      <select id="profile_upload" name="profile">
        <option value="none">Žádný zvláštní profil</option>
        <option value="css1">CSS Úroveň 1</option>
        <option value="css2">CSS Úroveň 2</option>
        <option value="css21">CSS Úroveň 2.1</option>
        <option value="css3">CSS Úroveň 3</option>
        <option selected="selected" value="css3svg">CSS Úroveň 3 + SVG</option>
        <option value="svg">SVG</option>
        <option value="svgbasic">SVG základní</option>
        <option value="svgtiny">SVG malý</option>  
        <option value="mobile">Mobil</option>
        <option value="atsc-tv">ATSC TV profil</option>
        <option value="tv">TV profil</option>
      </select>
    </td>
    <th id="header_medium_upload">
      <label for="medium_upload">Střední:</label>
    </th>
    <td headers="header_medium_upload">
      <select id="medium_upload" name="usermedium">
        <option selected="selected" value="all">Vše</option>
        <option value="aural">zvukový</option>
        <option value="braille">braillovo</option>
        <option value="embossed">vypouklý</option>
        <option value="handheld">do ruky</option>
        <option value="print">tisk</option>
        <option value= "projection">projekce</option>
        <option value="screen">obrazovka</option>
        <option value="tty">TTY</option>
        <option value="tv">TV</option>
        <option value="presentation">prezentace</option>
      </select>
    </td>
    </tr>
    <tr>
        <th id="header_warning_upload">
      <label for="warning_upload">Varování:</label>
    </th>
    <td
        colspan="1"
         headers="header_warning_upload">
      <select id="warning_upload" name="warning"> 
        <option value="2">Vše</option>
        <option selected="selected" value="1">Normální zpráva</option>
        <option value="0">Nejdůležitější</option>
        <option value="no">Žádné varování</option>
      </select>
    </td>

    <th id="header_vext_warning_upload">
      <label id="vext_warning_input">Vendor Extensions:</label>     
    </th>
    <td headers="header_vext_warning_upload">
      <select id="vext_warning_upload" name="vextwarning">
        <option value="">Default</option>
        <option value="true">Warnings</option>
        <option value="false">Errors</option>
      </select>
    </td>

    </tr>
    </table>
    </div><!-- item_contents -->
  </fieldset><!-- invisible -->
  
  <p class="submit_button">
  <input type="hidden" name="lang" value="cs" />
    <label title="Potvrďte soubor k ověření">
      <input type="submit" value="Zkontrolovat" />
    </label>
  </p>
      </form>
      </fieldset>

      <fieldset id="validate-by-input"  class="tabset_content front">
        <legend class="tabset_label">Ověřte přímým vstupem</legend>
        <form action="validator" enctype="multipart/form-data" method="post">
        <p class="instructions">Zadejte CSS, kterou chcete ověřit:</p>
        <p>
          <textarea name="text" rows="12" cols="70"></textarea>
        </p>      
              <fieldset id="extra_opt_input" class="moreoptions">
    <legend class="toggletext" title="Zobrazit/Skrýt další možnosti ověření">Další možnosti</legend>
    <div class="options">
    <table>
    <tr>
    <th id="header_profile_input">
      <label for="profile_input">Profil:</label>
    </th>
    <td headers="header_profile_input">
      <select id="profile_input" name="profile">
        <option value="none">Žádný zvláštní profil</option>
        <option value="css1">CSS Úroveň 1</option>
        <option value="css2">CSS Úroveň 2</option>
        <option value="css21">CSS Úroveň 2.1</option>
        <option value="css3">CSS Úroveň 3</option>
        <option selected="selected" value="css3svg">CSS Úroveň 3 + SVG</option>
        <option value="svg">SVG</option>
        <option value="svgbasic">SVG základní</option>
        <option value="svgtiny">SVG malý</option>  
        <option value="mobile">Mobil</option>
        <option value="atsc-tv">ATSC TV profil</option>
        <option value="tv">TV profil</option>
      </select>
    </td>
    <th id="header_medium_input">
      <label for="medium_input">Střední:</label>
    </th>
    <td headers="header_medium_input">
      <select id="medium_input" name="usermedium">
        <option selected="selected" value="all">Vše</option>
        <option value="aural">zvukový</option>
        <option value="braille">braillovo</option>
        <option value="embossed">vypouklý</option>
        <option value="handheld">do ruky</option>
        <option value="print">tisk</option>
        <option value= "projection">projekce</option>
        <option value="screen">obrazovka</option>
        <option value="tty">TTY</option>
        <option value="tv">TV</option>
        <option value="presentation">prezentace</option>
      </select>
    </td>
    </tr>
    <tr>
        <th id="header_type_input">
      <label for="type_input">Typ:</label>
    </th>
    <td headers="header_type_input">
      <select id="type_input" name="type">
        <option selected="selected" value="none">Automaticky</option>
        <option value="html">HTML</option>
        <option value="css">CSS</option>
      </select>
    </td>
        <th id="header_warning_input">
      <label for="warning_input">Varování:</label>
    </th>
    <td
         headers="header_warning_input">
      <select id="warning_input" name="warning"> 
        <option value="2">Vše</option>
        <option selected="selected" value="1">Normální zpráva</option>
        <option value="0">Nejdůležitější</option>
        <option value="no">Žádné varování</option>
      </select>
    </td>

    <th id="header_vext_warning_input">
      <label id="vext_warning_input">Vendor Extensions:</label>     
    </th>
    <td headers="header_vext_warning_input">
      <select id="vext_warning_input" name="vextwarning">
        <option value="">Default</option>
        <option value="true">Warnings</option>
        <option value="false">Errors</option>
      </select>
    </td>

    </tr>
    </table>
    </div><!-- item_contents -->
  </fieldset><!-- invisible -->
  
  <p class="submit_button">
  <input type="hidden" name="lang" value="cs" />
    <label title="Potvrďte vstup pro ověření">
      <input type="submit" value="Zkontrolovat" />
    </label>
  </p>
      </form>
      </fieldset>
      </div><!-- fields -->
  </div> <!-- frontforms -->
  
  <div id="w3c-include"><script type="text/javascript" src="//www.w3.org/QA/Tools/w3c-include.js"></script></div>

  <div class="intro">
  <p><strong>Poznámka</strong>: Pokud chcete ověřit svůj CSS styl vložený do dokumentu (X)HTML měli byste nejprve zkontrolovat  <a href="http://validator.w3.org/">, že vámi použité (X)HTML je platné </a>.
  </p>
  </div>
  <ul class="navbar" id="menu">
    <li><a href="about.html" title="O této službě">O</a> <span class="hideme">|</span></li>
    <li><a href="documentation.html" title="Dokumentace pro validační službu W3C CSS">Dokumentace</a> <span class="hideme">|</span></li>
    <li><a href="DOWNLOAD.html" title="Stáhnout a nainstalovat validátor CSS">Stáhnout</a> <span class="hideme">|</span></li>
    <li><a href="Email.html" title="Jak poskytnout feedback ohledně této služby">Feedback</a> <span class="hideme">|</span></li>
    <li><a href="thanks.html" title="Kredity a potvrzení">Kredity</a></li>
  </ul>

   <ul id="lang_choice">
        
        <li><a href="validator.html.de"
            lang="de"
            xml:lang="de"
            hreflang="de"
            rel="alternate">Deutsch</a>
        </li>
        
        <li><a href="validator.html.en"
            lang="en"
            xml:lang="en"
            hreflang="en"
            rel="alternate">English</a>
        </li>
        
        <li><a href="validator.html.es"
            lang="es"
            xml:lang="es"
            hreflang="es"
            rel="alternate">Español</a>
        </li>
        
        <li><a href="validator.html.fr"
            lang="fr"
            xml:lang="fr"
            hreflang="fr"
            rel="alternate">Français</a>
        </li>
        
        <li><a href="validator.html.ko"
            lang="ko"
            xml:lang="ko"
            hreflang="ko"
            rel="alternate">한국어</a>
        </li>
        
        <li><a href="validator.html.it"
            lang="it"
            xml:lang="it"
            hreflang="it"
            rel="alternate">Italiano</a>
        </li>
        
        <li><a href="validator.html.nl"
            lang="nl"
            xml:lang="nl"
            hreflang="nl"
            rel="alternate">Nederlands</a>
        </li>
        
        <li><a href="validator.html.ja"
            lang="ja"
            xml:lang="ja"
            hreflang="ja"
            rel="alternate">日本語</a>
        </li>
        
        <li><a href="validator.html.pl-PL"
            lang="pl-PL"
            xml:lang="pl-PL"
            hreflang="pl-PL"
            rel="alternate">Polski</a>
        </li>
        
        <li><a href="validator.html.pt-BR"
            lang="pt-BR"
            xml:lang="pt-BR"
            hreflang="pt-BR"
            rel="alternate">Português</a>
        </li>
        
        <li><a href="validator.html.ru"
            lang="ru"
            xml:lang="ru"
            hreflang="ru"
            rel="alternate">Русский</a>
        </li>
        
        <li><a href="validator.html.fa"
            lang="fa"
            xml:lang="fa"
            hreflang="fa"
            rel="alternate">فارسی</a>
        </li>
        
        <li><a href="validator.html.sv"
            lang="sv"
            xml:lang="sv"
            hreflang="sv"
            rel="alternate">Svenska</a>
        </li>
        
        <li><a href="validator.html.bg"
            lang="bg"
            xml:lang="bg"
            hreflang="bg"
            rel="alternate">Български</a>
        </li>
        
        <li><a href="validator.html.uk"
            lang="uk"
            xml:lang="uk"
            hreflang="uk"
            rel="alternate">Українська</a>
        </li>
        
        <li><a href="validator.html.cs"
            lang="cs"
            xml:lang="cs"
            hreflang="cs"
            rel="alternate">Čeština</a>
        </li>
        
        <li><a href="validator.html.ro"
            lang="ro"
            xml:lang="ro"
            hreflang="ro"
            rel="alternate">Romanian</a>
        </li>
        
        <li><a href="validator.html.hu"
            lang="hu"
            xml:lang="hu"
            hreflang="hu"
            rel="alternate">Magyar</a>
        </li>
        
        <li><a href="validator.html.el"
            lang="el"
            xml:lang="el"
            hreflang="el"
            rel="alternate">Ελληνικά</a>
        </li>
        
        <li><a href="validator.html.hi"
            lang="hi"
            xml:lang="hi"
            hreflang="hi"
            rel="alternate">हिन्दी</a>
        </li>
        
        <li><a href="validator.html.zh-cn"
            lang="zh-cn"
            xml:lang="zh-cn"
            hreflang="zh-cn"
            rel="alternate">简体中文</a>
        </li>
   </ul>

<div id="footer">
   <p id="activity_logos">
     <a href="//www.w3.org/QA/" title="Činnost zajištění kvality W3C vám přináší webové nástroje zdarma a mnohem více "><img src="//www.w3.org/QA/2002/12/qa-small.png" alt="QA" /></a><a href="//www.w3.org/Style/CSS/learning" title="Dozvědět se více o tabulkách kaskádových stylů"><img src="images/woolly-icon" alt="CSS" /></a>
   </p>
   <p id="support_logo">
   <a href="//www.w3.org/QA/Tools/Donate">
   <img src="//www.w3.org/QA/Tools/I_heart_validator" alt="I heart Validator logo" title=" Validators Donation Program" />
   </a>
   </p>

    <p class="copyright">
      <a rel="Copyright" href="http://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> &copy; 1994-2009
      <a href="http://www.w3.org/"><acronym title="World Wide Web Consortium">W3C</acronym></a>&reg;

      (<a href="http://www.csail.mit.edu/"><acronym title="Massachusetts Institute of Technology">MIT</acronym></a>,
      <a href="http://www.ercim.eu/"><acronym title="European Research Consortium for Informatics and Mathematics">ERCIM</acronym></a>,
      <a href="http://www.keio.ac.jp/">Keio</a>),
      All Rights Reserved.
      W3C <a href="http://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>,
      <a href="http://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a>,
      <a rel="Copyright" href="http://www.w3.org/Consortium/Legal/copyright-documents">document use</a>
      and <a rel="Copyright" href="http://www.w3.org/Consortium/Legal/copyright-software">software licensing</a>

      rules apply. Your interactions with this site are in accordance
      with our <a href="http://www.w3.org/Consortium/Legal/privacy-statement#Public">public</a> and
      <a href="http://www.w3.org/Consortium/Legal/privacy-statement#Members">Member</a> privacy
      statements.
    </p>
</div>
  </body>
</html>
