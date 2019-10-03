/*
               File: wc_SignosVitales
        Description: Registro de Signos Vitales
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:30.63
       Program type: Callable routine
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
   public class wc_signosvitales : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wc_signosvitales( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wc_signosvitales( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         cmbavSignoestaturaen = new GXCombobox();
         cmbavSignopesoen = new GXCombobox();
         cmbavSignotemperaturade = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  nDynComponent = 1 ;
                  sCompPrefix = GetNextPar( ) ;
                  sSFPrefix = GetNextPar( ) ;
                  A41ClinicaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A41ClinicaCodigo,(int)A91ConsultaId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
            PA1K2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS1K2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.WriteHtmlText( "<title>") ;
            context.WriteHtmlText( "Registro de Signos Vitales") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;") ;
            context.WriteHtmlText( "\""+FormProcess+">") ;
            context.skipLines(1);
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(A41ClinicaCodigo)) + "," + UrlEncode("" +A91ConsultaId) ;
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wc_signosvitales.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm1K2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA41ClinicaCodigo", StringUtil.RTrim( wcpOA41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA91ConsultaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA91ConsultaId), 9, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("wc_signosvitales.js", "?1533066");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            context.WriteHtmlTextNl( "</form>") ;
            include_jscripts( ) ;
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB1K0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wc_signosvitales.aspx");
            }
            wb_table1_2_1K2( true) ;
         }
         else
         {
            wb_table1_2_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1K2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1K2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) != 0 )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
            Form.Meta.addItem("Description", "Registro de Signos Vitales", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP1K0( ) ;
            }
         }
      }

      protected void WS1K2( )
      {
         START1K2( ) ;
         EVT1K2( ) ;
      }

      protected void EVT1K2( )
      {
         sXEvt = cgiGet( "_EventName") ;
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName") ;
                     EvtGridId = cgiGet( "_EventGridId") ;
                     EvtRowId = cgiGet( "_EventRowId") ;
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1K0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGISTRAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1K0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E111K2 */
                                    E111K2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1K0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E121K2 */
                                    E121K2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1K0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1K0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavSignoestatura_Internalname ;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
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

      protected void WE1K2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1K2( ) ;
            }
         }
      }

      protected void PA1K2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  GxWebError = 1 ;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
               }
               if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
               {
                  GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
                  GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
                  if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
                  {
                     SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
                  }
                  else
                  {
                     GxWebError = 1 ;
                     context.HttpContext.Response.StatusDescription = 403.ToString();
                     context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                     context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                     context.WriteHtmlText( "<p /><hr />") ;
                  }
               }
            }
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( StringUtil.Len( sPrefix) == 0 )
               {
                  if ( nGotPars == 0 )
                  {
                     entryPointCalled = false ;
                     gxfirstwebparm = GetNextPar( ) ;
                  }
               }
            }
            cmbavSignoestaturaen.Name = "vSIGNOESTATURAEN" ;
            cmbavSignoestaturaen.WebTags = "" ;
            cmbavSignoestaturaen.addItem("CM", "Centímetros", 0);
            cmbavSignoestaturaen.addItem("ME", "Metros", 0);
            if ( ( cmbavSignoestaturaen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV6SignoEstaturaEn)) )
            {
               AV6SignoEstaturaEn = cmbavSignoestaturaen.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6SignoEstaturaEn", AV6SignoEstaturaEn);
            }
            cmbavSignopesoen.Name = "vSIGNOPESOEN" ;
            cmbavSignopesoen.WebTags = "" ;
            cmbavSignopesoen.addItem("Lb", "Libras", 0);
            cmbavSignopesoen.addItem("Gr", "Gramos", 0);
            cmbavSignopesoen.addItem("Kg", "KGramos", 0);
            if ( ( cmbavSignopesoen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8SignoPesoEn)) )
            {
               AV8SignoPesoEn = cmbavSignopesoen.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SignoPesoEn", AV8SignoPesoEn);
            }
            cmbavSignotemperaturade.Name = "vSIGNOTEMPERATURADE" ;
            cmbavSignotemperaturade.WebTags = "" ;
            cmbavSignotemperaturade.addItem("Or", "Oral", 0);
            cmbavSignotemperaturade.addItem("Ax", "Axilar", 0);
            cmbavSignotemperaturade.addItem("Re", "Rectal", 0);
            cmbavSignotemperaturade.addItem("Fr", "Frontal", 0);
            if ( ( cmbavSignotemperaturade.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10SignoTemperaturaDe)) )
            {
               AV10SignoTemperaturaDe = cmbavSignotemperaturade.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10SignoTemperaturaDe", AV10SignoTemperaturaDe);
            }
            GX_FocusControl = edtavSignoestatura_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF1K2( ) ;
         /* End function Refresh */
      }

      protected void RF1K2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001K2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               /* Execute user event: E121K2 */
               E121K2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB1K0( ) ;
         }
      }

      protected void STRUP1K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSignoestatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSignoestatura_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSIGNOESTATURA");
               GX_FocusControl = edtavSignoestatura_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV5SignoEstatura = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5SignoEstatura", StringUtil.LTrim( StringUtil.Str( AV5SignoEstatura, 8, 2)));
            }
            else
            {
               AV5SignoEstatura = context.localUtil.CToN( cgiGet( edtavSignoestatura_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5SignoEstatura", StringUtil.LTrim( StringUtil.Str( AV5SignoEstatura, 8, 2)));
            }
            cmbavSignoestaturaen.CurrentValue = cgiGet( cmbavSignoestaturaen_Internalname) ;
            AV6SignoEstaturaEn = cgiGet( cmbavSignoestaturaen_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6SignoEstaturaEn", AV6SignoEstaturaEn);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSignopeso_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSignopeso_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSIGNOPESO");
               GX_FocusControl = edtavSignopeso_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7SignoPeso = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7SignoPeso", StringUtil.LTrim( StringUtil.Str( AV7SignoPeso, 8, 2)));
            }
            else
            {
               AV7SignoPeso = context.localUtil.CToN( cgiGet( edtavSignopeso_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7SignoPeso", StringUtil.LTrim( StringUtil.Str( AV7SignoPeso, 8, 2)));
            }
            cmbavSignopesoen.CurrentValue = cgiGet( cmbavSignopesoen_Internalname) ;
            AV8SignoPesoEn = cgiGet( cmbavSignopesoen_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SignoPesoEn", AV8SignoPesoEn);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSignotemperatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSignotemperatura_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSIGNOTEMPERATURA");
               GX_FocusControl = edtavSignotemperatura_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9SignoTemperatura = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9SignoTemperatura", StringUtil.LTrim( StringUtil.Str( AV9SignoTemperatura, 8, 2)));
            }
            else
            {
               AV9SignoTemperatura = context.localUtil.CToN( cgiGet( edtavSignotemperatura_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9SignoTemperatura", StringUtil.LTrim( StringUtil.Str( AV9SignoTemperatura, 8, 2)));
            }
            cmbavSignotemperaturade.CurrentValue = cgiGet( cmbavSignotemperaturade_Internalname) ;
            AV10SignoTemperaturaDe = cgiGet( cmbavSignotemperaturade_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10SignoTemperaturaDe", AV10SignoTemperaturaDe);
            AV11SignoPresionArterial = cgiGet( edtavSignopresionarterial_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11SignoPresionArterial", AV11SignoPresionArterial);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSignofreccardiaca_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSignofreccardiaca_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSIGNOFRECCARDIACA");
               GX_FocusControl = edtavSignofreccardiaca_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12SignoFrecCardiaca = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SignoFrecCardiaca", StringUtil.LTrim( StringUtil.Str( AV12SignoFrecCardiaca, 8, 2)));
            }
            else
            {
               AV12SignoFrecCardiaca = context.localUtil.CToN( cgiGet( edtavSignofreccardiaca_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SignoFrecCardiaca", StringUtil.LTrim( StringUtil.Str( AV12SignoFrecCardiaca, 8, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSignofrecrespiratoria_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSignofrecrespiratoria_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSIGNOFRECRESPIRATORIA");
               GX_FocusControl = edtavSignofrecrespiratoria_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13SignoFrecRespiratoria = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13SignoFrecRespiratoria", StringUtil.LTrim( StringUtil.Str( AV13SignoFrecRespiratoria, 8, 2)));
            }
            else
            {
               AV13SignoFrecRespiratoria = context.localUtil.CToN( cgiGet( edtavSignofrecrespiratoria_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13SignoFrecRespiratoria", StringUtil.LTrim( StringUtil.Str( AV13SignoFrecRespiratoria, 8, 2)));
            }
            AV14SignoObs = cgiGet( edtavSignoobs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14SignoObs", AV14SignoObs);
            /* Read saved values. */
            wcpOA41ClinicaCodigo = cgiGet( sPrefix+"wcpOA41ClinicaCodigo") ;
            wcpOA91ConsultaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA91ConsultaId"), ".", ",")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E111K2( )
      {
         /* 'Registrar' Routine */
         new pregistrasignosvitales(context ).execute( ref  A41ClinicaCodigo, ref  A91ConsultaId, ref  AV5SignoEstatura, ref  AV6SignoEstaturaEn, ref  AV12SignoFrecCardiaca, ref  AV13SignoFrecRespiratoria, ref  AV14SignoObs, ref  AV7SignoPeso, ref  AV8SignoPesoEn, ref  AV11SignoPresionArterial, ref  AV9SignoTemperatura, ref  AV10SignoTemperaturaDe) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5SignoEstatura", StringUtil.LTrim( StringUtil.Str( AV5SignoEstatura, 8, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6SignoEstaturaEn", AV6SignoEstaturaEn);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SignoFrecCardiaca", StringUtil.LTrim( StringUtil.Str( AV12SignoFrecCardiaca, 8, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13SignoFrecRespiratoria", StringUtil.LTrim( StringUtil.Str( AV13SignoFrecRespiratoria, 8, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14SignoObs", AV14SignoObs);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7SignoPeso", StringUtil.LTrim( StringUtil.Str( AV7SignoPeso, 8, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SignoPesoEn", AV8SignoPesoEn);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11SignoPresionArterial", AV11SignoPresionArterial);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9SignoTemperatura", StringUtil.LTrim( StringUtil.Str( AV9SignoTemperatura, 8, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10SignoTemperaturaDe", AV10SignoTemperaturaDe);
         GX_msglist.addItem("Signos Vitales registrados exitosamente.");
      }

      protected void nextLoad( )
      {
      }

      protected void E121K2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_1K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:27px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Registro de Signos Vitales", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_11_1K2( true) ;
         }
         else
         {
            wb_table2_11_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_35_1K2( true) ;
         }
         else
         {
            wb_table3_35_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table3_35_1K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table4_53_1K2( true) ;
         }
         else
         {
            wb_table4_53_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table4_53_1K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Registrar", bttButton1_Jsonclick, 5, "Registrar", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'REGISTRAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1K2e( true) ;
         }
         else
         {
            wb_table1_2_1K2e( false) ;
         }
      }

      protected void wb_table4_53_1K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Observaciones", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14SignoObs", AV14SignoObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_html_textarea( context, edtavSignoobs_Internalname, StringUtil.RTrim( AV14SignoObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_53_1K2e( true) ;
         }
         else
         {
            wb_table4_53_1K2e( false) ;
         }
      }

      protected void wb_table3_35_1K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Presión Arterial", "", "", lblTextblock10_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11SignoPresionArterial", AV11SignoPresionArterial);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavSignopresionarterial_Internalname, StringUtil.RTrim( AV11SignoPresionArterial), StringUtil.RTrim( context.localUtil.Format( AV11SignoPresionArterial, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(40);\"", "", "", "", "", edtavSignopresionarterial_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, true, "left", "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Frecuencia Cardiaca", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SignoFrecCardiaca", StringUtil.LTrim( StringUtil.Str( AV12SignoFrecCardiaca, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavSignofreccardiaca_Internalname, StringUtil.LTrim( StringUtil.NToC( AV12SignoFrecCardiaca, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV12SignoFrecCardiaca, "ZZZZ9.99")) : context.localUtil.Format( AV12SignoFrecCardiaca, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(45);\"", "", "", "", "", edtavSignofreccardiaca_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Frecuencia Respiratoria", "", "", lblTextblock8_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13SignoFrecRespiratoria", StringUtil.LTrim( StringUtil.Str( AV13SignoFrecRespiratoria, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavSignofrecrespiratoria_Internalname, StringUtil.LTrim( StringUtil.NToC( AV13SignoFrecRespiratoria, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV13SignoFrecRespiratoria, "ZZZZ9.99")) : context.localUtil.Format( AV13SignoFrecRespiratoria, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(50);\"", "", "", "", "", edtavSignofrecrespiratoria_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_35_1K2e( true) ;
         }
         else
         {
            wb_table3_35_1K2e( false) ;
         }
      }

      protected void wb_table2_11_1K2( bool wbgen )
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
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, "Estatura", "", "", lblTextblock13_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5SignoEstatura", StringUtil.LTrim( StringUtil.Str( AV5SignoEstatura, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavSignoestatura_Internalname, StringUtil.LTrim( StringUtil.NToC( AV5SignoEstatura, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV5SignoEstatura, "ZZZZ9.99")) : context.localUtil.Format( AV5SignoEstatura, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(16);\"", "", "", "", "", edtavSignoestatura_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6SignoEstaturaEn", AV6SignoEstaturaEn);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'" + sPrefix + "',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSignoestaturaen, cmbavSignoestaturaen_Internalname, AV6SignoEstaturaEn, 1, cmbavSignoestaturaen_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(18);\"", "", true, "HLP_wc_SignosVitales.htm");
            cmbavSignoestaturaen.CurrentValue = AV6SignoEstaturaEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavSignoestaturaen_Internalname, "Values", (String)(cmbavSignoestaturaen.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, "Peso", "", "", lblTextblock12_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7SignoPeso", StringUtil.LTrim( StringUtil.Str( AV7SignoPeso, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavSignopeso_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7SignoPeso, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7SignoPeso, "ZZZZ9.99")) : context.localUtil.Format( AV7SignoPeso, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(23);\"", "", "", "", "", edtavSignopeso_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SignoPesoEn", AV8SignoPesoEn);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'" + sPrefix + "',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSignopesoen, cmbavSignopesoen_Internalname, AV8SignoPesoEn, 1, cmbavSignopesoen_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(25);\"", "", true, "HLP_wc_SignosVitales.htm");
            cmbavSignopesoen.CurrentValue = AV8SignoPesoEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavSignopesoen_Internalname, "Values", (String)(cmbavSignopesoen.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Temperatura", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9SignoTemperatura", StringUtil.LTrim( StringUtil.Str( AV9SignoTemperatura, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavSignotemperatura_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9SignoTemperatura, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9SignoTemperatura, "ZZZZ9.99")) : context.localUtil.Format( AV9SignoTemperatura, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(30);\"", "", "", "", "", edtavSignotemperatura_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wc_SignosVitales.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10SignoTemperaturaDe", AV10SignoTemperaturaDe);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'" + sPrefix + "',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSignotemperaturade, cmbavSignotemperaturade_Internalname, AV10SignoTemperaturaDe, 1, cmbavSignotemperaturade_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(32);\"", "", true, "HLP_wc_SignosVitales.htm");
            cmbavSignotemperaturade.CurrentValue = AV10SignoTemperaturaDe ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavSignotemperaturade_Internalname, "Values", (String)(cmbavSignotemperaturade.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1K2e( true) ;
         }
         else
         {
            wb_table2_11_1K2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A41ClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A91ConsultaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
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
         PA1K2( ) ;
         WS1K2( ) ;
         WE1K2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA41ClinicaCodigo = (String)((String)getParm(obj,0)) ;
         sCtrlA91ConsultaId = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA1K2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "wc_signosvitales");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA1K2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A41ClinicaCodigo = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = Convert.ToInt32(getParm(obj,3)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         }
         wcpOA41ClinicaCodigo = cgiGet( sPrefix+"wcpOA41ClinicaCodigo") ;
         wcpOA91ConsultaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA91ConsultaId"), ".", ",")) ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A41ClinicaCodigo, wcpOA41ClinicaCodigo) != 0 ) || ( A91ConsultaId != wcpOA91ConsultaId ) ) )
         {
            setjustcreated();
         }
         wcpOA41ClinicaCodigo = A41ClinicaCodigo ;
         wcpOA91ConsultaId = A91ConsultaId ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA41ClinicaCodigo = cgiGet( sPrefix+"A41ClinicaCodigo_CTRL") ;
         if ( StringUtil.Len( sCtrlA41ClinicaCodigo) > 0 )
         {
            A41ClinicaCodigo = cgiGet( sCtrlA41ClinicaCodigo) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
         }
         else
         {
            A41ClinicaCodigo = cgiGet( sPrefix+"A41ClinicaCodigo_PARM") ;
         }
         sCtrlA91ConsultaId = cgiGet( sPrefix+"A91ConsultaId_CTRL") ;
         if ( StringUtil.Len( sCtrlA91ConsultaId) > 0 )
         {
            A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( sCtrlA91ConsultaId), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         }
         else
         {
            A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"A91ConsultaId_PARM"), ".", ",")) ;
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix ;
         sSFPrefix = sPSFPrefix ;
         sPrefix = sCompPrefix + sSFPrefix ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         INITWEB( ) ;
         nDraw = 0 ;
         PA1K2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS1K2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1 ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WS1K2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A41ClinicaCodigo_PARM", StringUtil.RTrim( A41ClinicaCodigo));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA41ClinicaCodigo)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A41ClinicaCodigo_CTRL", StringUtil.RTrim( sCtrlA41ClinicaCodigo));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A91ConsultaId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA91ConsultaId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A91ConsultaId_CTRL", StringUtil.RTrim( sCtrlA91ConsultaId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WCParametersSet( ) ;
         WE1K2( ) ;
         this.cleanup();
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1) ;
         }
         else
         {
            sCtrlName = sGXControl ;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?153318");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("wc_signosvitales.js", "?153318");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = sPrefix+"TEXTBLOCK1" ;
         lblTextblock13_Internalname = sPrefix+"TEXTBLOCK13" ;
         edtavSignoestatura_Internalname = sPrefix+"vSIGNOESTATURA" ;
         cmbavSignoestaturaen_Internalname = sPrefix+"vSIGNOESTATURAEN" ;
         lblTextblock12_Internalname = sPrefix+"TEXTBLOCK12" ;
         edtavSignopeso_Internalname = sPrefix+"vSIGNOPESO" ;
         cmbavSignopesoen_Internalname = sPrefix+"vSIGNOPESOEN" ;
         lblTextblock11_Internalname = sPrefix+"TEXTBLOCK11" ;
         edtavSignotemperatura_Internalname = sPrefix+"vSIGNOTEMPERATURA" ;
         cmbavSignotemperaturade_Internalname = sPrefix+"vSIGNOTEMPERATURADE" ;
         tblTable2_Internalname = sPrefix+"TABLE2" ;
         lblTextblock10_Internalname = sPrefix+"TEXTBLOCK10" ;
         edtavSignopresionarterial_Internalname = sPrefix+"vSIGNOPRESIONARTERIAL" ;
         lblTextblock9_Internalname = sPrefix+"TEXTBLOCK9" ;
         edtavSignofreccardiaca_Internalname = sPrefix+"vSIGNOFRECCARDIACA" ;
         lblTextblock8_Internalname = sPrefix+"TEXTBLOCK8" ;
         edtavSignofrecrespiratoria_Internalname = sPrefix+"vSIGNOFRECRESPIRATORIA" ;
         tblTable3_Internalname = sPrefix+"TABLE3" ;
         lblTextblock7_Internalname = sPrefix+"TEXTBLOCK7" ;
         edtavSignoobs_Internalname = sPrefix+"vSIGNOOBS" ;
         tblTable4_Internalname = sPrefix+"TABLE4" ;
         bttButton1_Internalname = sPrefix+"BUTTON1" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbavSignotemperaturade_Jsonclick = "" ;
         edtavSignotemperatura_Jsonclick = "" ;
         cmbavSignopesoen_Jsonclick = "" ;
         edtavSignopeso_Jsonclick = "" ;
         cmbavSignoestaturaen_Jsonclick = "" ;
         edtavSignoestatura_Jsonclick = "" ;
         edtavSignofrecrespiratoria_Jsonclick = "" ;
         edtavSignofreccardiaca_Jsonclick = "" ;
         edtavSignopresionarterial_Jsonclick = "" ;
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
         wcpOA41ClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXDecQS = "" ;
         AV6SignoEstaturaEn = "" ;
         AV8SignoPesoEn = "" ;
         AV10SignoTemperaturaDe = "" ;
         scmdbuf = "" ;
         H001K2_A41ClinicaCodigo = new String[] {""} ;
         H001K2_A91ConsultaId = new int[1] ;
         AV11SignoPresionArterial = "" ;
         AV14SignoObs = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock12_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA41ClinicaCodigo = "" ;
         sCtrlA91ConsultaId = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wc_signosvitales__default(),
            new Object[][] {
                new Object[] {
               H001K2_A41ClinicaCodigo, H001K2_A91ConsultaId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short nGXWrapped ;
      private int A91ConsultaId ;
      private int wcpOA91ConsultaId ;
      private int idxLst ;
      private decimal AV5SignoEstatura ;
      private decimal AV7SignoPeso ;
      private decimal AV9SignoTemperatura ;
      private decimal AV12SignoFrecCardiaca ;
      private decimal AV13SignoFrecRespiratoria ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSignoestatura_Internalname ;
      private String GXDecQS ;
      private String scmdbuf ;
      private String cmbavSignoestaturaen_Internalname ;
      private String edtavSignopeso_Internalname ;
      private String cmbavSignopesoen_Internalname ;
      private String edtavSignotemperatura_Internalname ;
      private String cmbavSignotemperaturade_Internalname ;
      private String edtavSignopresionarterial_Internalname ;
      private String edtavSignofreccardiaca_Internalname ;
      private String edtavSignofrecrespiratoria_Internalname ;
      private String edtavSignoobs_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtavSignopresionarterial_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavSignofreccardiaca_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtavSignofrecrespiratoria_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtavSignoestatura_Jsonclick ;
      private String cmbavSignoestaturaen_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtavSignopeso_Jsonclick ;
      private String cmbavSignopesoen_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavSignotemperatura_Jsonclick ;
      private String cmbavSignotemperaturade_Jsonclick ;
      private String sCtrlA41ClinicaCodigo ;
      private String sCtrlA91ConsultaId ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String wcpOA41ClinicaCodigo ;
      private String AV6SignoEstaturaEn ;
      private String AV8SignoPesoEn ;
      private String AV10SignoTemperaturaDe ;
      private String AV11SignoPresionArterial ;
      private String AV14SignoObs ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private GXCombobox cmbavSignoestaturaen ;
      private GXCombobox cmbavSignopesoen ;
      private GXCombobox cmbavSignotemperaturade ;
      private IDataStoreProvider pr_default ;
      private String[] H001K2_A41ClinicaCodigo ;
      private int[] H001K2_A91ConsultaId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class wc_signosvitales__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001K2 ;
          prmH001K2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001K2", "SELECT [ClinicaCodigo], [ConsultaId] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @ConsultaId ORDER BY [ClinicaCodigo], [ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K2,1,0,true,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
