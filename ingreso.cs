/*
               File: ingreso
        Description: Ingreso al sistema
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:39.60
       Program type: Main program
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ingreso : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public ingreso( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public ingreso( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavClinicacodigo = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
         }
         context.SetTheme("Fantastic");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA042( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START042( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?58720");
            context.AddJavascriptSource("gxfxSD.js", "?58720");
            context.AddJavascriptSource("gxtypesSD.js", "?58720");
            context.AddJavascriptSource("gxpopupSD.js", "?58720");
            context.AddJavascriptSource("gxfrmutlSD.js", "?58720");
            context.AddJavascriptSource("gxgridSD.js", "?58720");
            context.AddJavascriptSource("JavaScripTableSD.js", "?58720");
            context.AddJavascriptSource("rijndaelSD.js", "?58720");
            context.AddJavascriptSource("gxgralSD.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ingreso.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE042( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT042( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "ingreso" ;
      }

      public override String GetPgmdesc( )
      {
         return "Ingreso al sistema" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ingreso.aspx")  ;
      }

      protected void WB040( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_042( true) ;
         }
         else
         {
            wb_table1_2_042( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_042e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START042( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Ingreso al sistema", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP040( ) ;
      }

      protected void WS042( )
      {
         START042( ) ;
         EVT042( ) ;
      }

      protected void EVT042( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'INGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11042 */
                              E11042 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12042 */
                              E12042 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE042( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA042( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            dynavClinicacodigo.Name = "vCLINICACODIGO" ;
            dynavClinicacodigo.WebTags = "" ;
            dynavClinicacodigo.removeAllItems();
            /* Using cursor H00042 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               dynavClinicacodigo.addItem(H00042_A41ClinicaCodigo[0], H00042_A42ClinicaNombre[0], 0);
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( ( dynavClinicacodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8ClinicaCodigo)) )
            {
               AV8ClinicaCodigo = dynavClinicacodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
            }
            GX_FocusControl = edtavUsuariocodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF042( ) ;
         /* End function Refresh */
      }

      protected void RF042( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E12042 */
            E12042 ();
            WB040( ) ;
         }
      }

      protected void STRUP040( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6UsuarioCodigo = cgiGet( edtavUsuariocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6UsuarioCodigo", AV6UsuarioCodigo);
            AV7UsuarioContrasena = cgiGet( edtavUsuariocontrasena_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuarioContrasena", AV7UsuarioContrasena);
            dynavClinicacodigo.CurrentValue = cgiGet( dynavClinicacodigo_Internalname) ;
            AV8ClinicaCodigo = cgiGet( dynavClinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E11042( )
      {
         /* 'Ingresar' Routine */
         /* Using cursor H00043 */
         pr_default.execute(1, new Object[] {AV6UsuarioCodigo});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A4UsuarioCodigo = H00043_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            A7UsuarioEstado = H00043_A7UsuarioEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
            A6UsuarioContrasena = H00043_A6UsuarioContrasena[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6UsuarioContrasena", A6UsuarioContrasena);
            A1GrupoCodigo = H00043_A1GrupoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            if ( A7UsuarioEstado == 1 )
            {
               if ( StringUtil.StrCmp(A6UsuarioContrasena, AV7UsuarioContrasena) == 0 )
               {
                  /* Execute user subroutine: S113 */
                  S113 ();
                  if ( returnInSub )
                  {
                     pr_default.close(1);
                     returnInSub = true;
                     if (true) return;
                  }
                  AV5Parametros.gxTpr_Pgrupocodigo = A1GrupoCodigo ;
                  context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5Parametros", (Object)(AV5Parametros));
                  AV5Parametros.gxTpr_Pusuariocodigo = A4UsuarioCodigo ;
                  context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5Parametros", (Object)(AV5Parametros));
                  AV5Parametros.gxTpr_Pclinicacodigo = AV8ClinicaCodigo ;
                  context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5Parametros", (Object)(AV5Parametros));
                  AV5Parametros.gxTpr_Pcajacodigo = AV10CajaCodigo ;
                  context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5Parametros", (Object)(AV5Parametros));
                  new pregistrasesion(context ).execute(  AV5Parametros) ;
                  context.wjLoc = formatLink("principal.aspx")  ;
               }
               else
               {
                  GX_msglist.addItem("Usuario esta de baja y/o contraseña es incorrecta.");
               }
            }
            else
            {
               GX_msglist.addItem("Usuario esta de baja y/o contraseña es incorrecta.");
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void S113( )
      {
         /* 'OBTIENE CAJA' Routine */
         AV14GXLvl24 = 0 ;
         /* Using cursor H00044 */
         pr_default.execute(2, new Object[] {AV8ClinicaCodigo, AV6UsuarioCodigo});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A259CajeroCodigo = H00044_A259CajeroCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259CajeroCodigo", A259CajeroCodigo);
            A41ClinicaCodigo = H00044_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = H00044_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            AV14GXLvl24 = 1 ;
            AV10CajaCodigo = A132CajaCodigo ;
            pr_default.readNext(2);
         }
         pr_default.close(2);
         if ( AV14GXLvl24 == 0 )
         {
            AV10CajaCodigo = "" ;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E12042( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_042( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_8_042( true) ;
         }
         else
         {
            wb_table2_8_042( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_042e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Ingresar", bttButton1_Jsonclick, 5, "Ingresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'INGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_ingreso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_042e( true) ;
         }
         else
         {
            wb_table1_2_042e( false) ;
         }
      }

      protected void wb_table2_8_042( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:14.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Usuario", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ingreso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6UsuarioCodigo", AV6UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:14.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavUsuariocodigo_Internalname, StringUtil.RTrim( AV6UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( AV6UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(13);\"", "", "", "", "", edtavUsuariocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_ingreso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:14.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Contraseña", "", "", lblTextblock2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ingreso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuarioContrasena", AV7UsuarioContrasena);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:14.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavUsuariocontrasena_Internalname, StringUtil.RTrim( AV7UsuarioContrasena), StringUtil.RTrim( context.localUtil.Format( AV7UsuarioContrasena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(18);\"", "", "", "", "", edtavUsuariocontrasena_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, -1, 0, 0, 1, -1, true, "left", "HLP_ingreso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:14.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Empresa", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_ingreso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:14.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavClinicacodigo, dynavClinicacodigo_Internalname, AV8ClinicaCodigo, 1, dynavClinicacodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 489, "px", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(23);\"", "", true, "HLP_ingreso.htm");
            dynavClinicacodigo.CurrentValue = AV8ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavClinicacodigo_Internalname, "Values", (String)(dynavClinicacodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_042e( true) ;
         }
         else
         {
            wb_table2_8_042e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA042( ) ;
         WS042( ) ;
         WE042( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1573984");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("ingreso.js", "?1573984");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavUsuariocodigo_Internalname = "vUSUARIOCODIGO" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavUsuariocontrasena_Internalname = "vUSUARIOCONTRASENA" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         dynavClinicacodigo_Internalname = "vCLINICACODIGO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         dynavClinicacodigo_Jsonclick = "" ;
         edtavUsuariocontrasena_Jsonclick = "" ;
         edtavUsuariocodigo_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Ingreso al sistema" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXKey = "" ;
         scmdbuf = "" ;
         H00042_A41ClinicaCodigo = new String[] {""} ;
         H00042_A42ClinicaNombre = new String[] {""} ;
         AV8ClinicaCodigo = "" ;
         AV6UsuarioCodigo = "" ;
         AV7UsuarioContrasena = "" ;
         H00043_A4UsuarioCodigo = new String[] {""} ;
         H00043_A7UsuarioEstado = new short[1] ;
         H00043_A6UsuarioContrasena = new String[] {""} ;
         H00043_A1GrupoCodigo = new String[] {""} ;
         A4UsuarioCodigo = "" ;
         A6UsuarioContrasena = "" ;
         A1GrupoCodigo = "" ;
         AV5Parametros = new SdtParametros(context);
         AV10CajaCodigo = "" ;
         H00044_A259CajeroCodigo = new String[] {""} ;
         H00044_A41ClinicaCodigo = new String[] {""} ;
         H00044_A132CajaCodigo = new String[] {""} ;
         A259CajeroCodigo = "" ;
         A41ClinicaCodigo = "" ;
         A132CajaCodigo = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         GXt_char3 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ingreso__default(),
            new Object[][] {
                new Object[] {
               H00042_A41ClinicaCodigo, H00042_A42ClinicaNombre
               }
               , new Object[] {
               H00043_A4UsuarioCodigo, H00043_A7UsuarioEstado, H00043_A6UsuarioContrasena, H00043_A1GrupoCodigo
               }
               , new Object[] {
               H00044_A259CajeroCodigo, H00044_A41ClinicaCodigo, H00044_A132CajaCodigo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A7UsuarioEstado ;
      private short AV14GXLvl24 ;
      private short nGXWrapped ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXKey ;
      private String scmdbuf ;
      private String edtavUsuariocodigo_Internalname ;
      private String edtavUsuariocontrasena_Internalname ;
      private String dynavClinicacodigo_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavUsuariocodigo_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavUsuariocontrasena_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String dynavClinicacodigo_Jsonclick ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV8ClinicaCodigo ;
      private String AV6UsuarioCodigo ;
      private String AV7UsuarioContrasena ;
      private String A4UsuarioCodigo ;
      private String A6UsuarioContrasena ;
      private String A1GrupoCodigo ;
      private String AV10CajaCodigo ;
      private String A259CajeroCodigo ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavClinicacodigo ;
      private IDataStoreProvider pr_default ;
      private String[] H00042_A41ClinicaCodigo ;
      private String[] H00042_A42ClinicaNombre ;
      private String[] H00043_A4UsuarioCodigo ;
      private short[] H00043_A7UsuarioEstado ;
      private String[] H00043_A6UsuarioContrasena ;
      private String[] H00043_A1GrupoCodigo ;
      private String[] H00044_A259CajeroCodigo ;
      private String[] H00044_A41ClinicaCodigo ;
      private String[] H00044_A132CajaCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
   }

   public class ingreso__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00042 ;
          prmH00042 = new Object[] {
          } ;
          Object[] prmH00043 ;
          prmH00043 = new Object[] {
          new Object[] {"@AV6UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH00044 ;
          prmH00044 = new Object[] {
          new Object[] {"@AV8ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00042", "SELECT [ClinicaCodigo], [ClinicaNombre] FROM [Clinica] WITH (NOLOCK) ORDER BY [ClinicaNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00042,0,0,true,false )
             ,new CursorDef("H00043", "SELECT [UsuarioCodigo], [UsuarioEstado], [UsuarioContrasena], [GrupoCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @AV6UsuarioCodigo ORDER BY [UsuarioCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00043,1,0,true,true )
             ,new CursorDef("H00044", "SELECT [CajeroCodigo], [ClinicaCodigo], [CajaCodigo] FROM [Caja] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV8ClinicaCodigo) AND ([CajeroCodigo] = @AV6UsuarioCodigo) ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00044,100,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
