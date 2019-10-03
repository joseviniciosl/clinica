/*
               File: CalendarioGeneral
        Description: Calendario General
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 15:21:39.23
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class calendariogeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public calendariogeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public calendariogeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           String aP1_CalendarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A233CalendarioCodigo = aP1_CalendarioCodigo;
         executePrivate();
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
                  A233CalendarioCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233CalendarioCodigo", A233CalendarioCodigo);
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A41ClinicaCodigo,(String)A233CalendarioCodigo});
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
            PA2F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "CalendarioGeneral" ;
               context.Gx_err = 0 ;
               WS2F2( ) ;
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
            context.WriteHtmlText( "Calendario General") ;
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
         context.AddJavascriptSource("calendar.js", "?58720");
         context.AddJavascriptSource("calendar-setup.js", "?58720");
         context.AddJavascriptSource("calendar-es.js", "?58720");
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;") ;
            context.WriteHtmlText( "\""+FormProcess+">") ;
            context.skipLines(1);
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(A41ClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(A233CalendarioCodigo)) ;
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("calendariogeneral.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm2F2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA41ClinicaCodigo", StringUtil.RTrim( wcpOA41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA233CalendarioCodigo", StringUtil.RTrim( wcpOA233CalendarioCodigo));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("calendariogeneral.js", "?15213926");
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

      protected void WB2F0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "calendariogeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_2F2( true) ;
         }
         else
         {
            wb_table1_2_2F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2F2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Modifica", bttBtnupdate_Jsonclick, 5, "Modifica", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", context.GetButtonType( ), "HLP_CalendarioGeneral.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Eliminar", bttBtndelete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'DODELETE\\'.", TempTags, "", context.GetButtonType( ), "HLP_CalendarioGeneral.htm");
         }
         wbLoad = true ;
      }

      protected void START2F2( )
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
            Form.Meta.addItem("Description", "Calendario General", 0) ;
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
               STRUP2F0( ) ;
            }
         }
      }

      protected void WS2F2( )
      {
         START2F2( ) ;
         EVT2F2( ) ;
      }

      protected void EVT2F2( )
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
                                 STRUP2F0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2F0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E112F2 */
                                    E112F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2F0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E122F2 */
                                    E122F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2F0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E132F2 */
                                    E132F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2F0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E142F2 */
                                    E142F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2F0( ) ;
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
                                 STRUP2F0( ) ;
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

      protected void WE2F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2F2( ) ;
            }
         }
      }

      protected void PA2F2( )
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
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF2F2( ) ;
         /* End function Refresh */
      }

      protected void RF2F2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H002F2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A236CalendarioFinal = H002F2_A236CalendarioFinal[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
               A235CalendarioInicio = H002F2_A235CalendarioInicio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
               A67PacienteId = H002F2_A67PacienteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               A234CalendarioObs = H002F2_A234CalendarioObs[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A234CalendarioObs", A234CalendarioObs);
               /* Execute user event: E122F2 */
               E122F2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB2F0( ) ;
         }
      }

      protected void STRUP2F0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "CalendarioGeneral" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112F2 */
         E112F2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A234CalendarioObs = cgiGet( edtCalendarioObs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A234CalendarioObs", A234CalendarioObs);
            A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A235CalendarioInicio = context.localUtil.CToT( cgiGet( edtCalendarioInicio_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
            A236CalendarioFinal = context.localUtil.CToT( cgiGet( edtCalendarioFinal_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
            /* Read saved values. */
            wcpOA41ClinicaCodigo = cgiGet( sPrefix+"wcpOA41ClinicaCodigo") ;
            wcpOA233CalendarioCodigo = cgiGet( sPrefix+"wcpOA233CalendarioCodigo") ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E112F2 */
         E112F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112F2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV15Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
               }
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV15Pgmname)) ;
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E122F2( )
      {
         /* Load Routine */
      }

      protected void E132F2( )
      {
         /* 'DoUpdate' Routine */
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A41ClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(A233CalendarioCodigo)) ;
         context.wjLoc = formatLink("calendario.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E142F2( )
      {
         /* 'DoDelete' Routine */
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A41ClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(A233CalendarioCodigo)) ;
         context.wjLoc = formatLink("calendario.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new SdtTransactionContext(context) ;
         AV9TrnContext.gxTpr_Callerobject = AV15Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV9TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV9TrnContext.gxTpr_Transactionname = "Calendario" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "ClinicaCodigo" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = AV7ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "CalendarioCodigo" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = AV8CalendarioCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, "TransactionContext", "Clinica"));
      }

      protected void wb_table1_2_2F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTbl2_Internalname, tblTbl2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), "", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, 1, true, "left", "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendariocodigo_Internalname, "Id", "", "", lblTextblockcalendariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233CalendarioCodigo", A233CalendarioCodigo);
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCalendarioCodigo_Internalname, StringUtil.RTrim( A233CalendarioCodigo), StringUtil.RTrim( context.localUtil.Format( A233CalendarioCodigo, "")), "", "", "", "", "", edtCalendarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, 1, true, "left", "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendarioobs_Internalname, "Observaciones", "", "", lblTextblockcalendarioobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A234CalendarioObs", A234CalendarioObs);
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtCalendarioObs_Internalname, StringUtil.RTrim( A234CalendarioObs), "", "", 0, 1, 0, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9"), "", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, 1, true, "right", "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendarioinicio_Internalname, "Inicia", "", "", lblTextblockcalendarioinicio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCalendarioInicio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCalendarioInicio_Internalname, context.localUtil.Format(A235CalendarioInicio, "99/99/99 99:99"), context.localUtil.Format( A235CalendarioInicio, "99/99/99 99:99"), "", "", "", "", "", edtCalendarioInicio_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, 1, true, "right", "HLP_CalendarioGeneral.htm");
            GxWebStd.gx_bitmap( context, edtCalendarioInicio_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_CalendarioGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendariofinal_Internalname, "Final", "", "", lblTextblockcalendariofinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CalendarioGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCalendarioFinal_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCalendarioFinal_Internalname, context.localUtil.Format(A236CalendarioFinal, "99/99/99 99:99"), context.localUtil.Format( A236CalendarioFinal, "99/99/99 99:99"), "", "", "", "", "", edtCalendarioFinal_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, 1, true, "right", "HLP_CalendarioGeneral.htm");
            GxWebStd.gx_bitmap( context, edtCalendarioFinal_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_CalendarioGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2F2e( true) ;
         }
         else
         {
            wb_table1_2_2F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A41ClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A233CalendarioCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233CalendarioCodigo", A233CalendarioCodigo);
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
         PA2F2( ) ;
         WS2F2( ) ;
         WE2F2( ) ;
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
         sCtrlA233CalendarioCodigo = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA2F2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "calendariogeneral");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA2F2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A41ClinicaCodigo = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A233CalendarioCodigo = (String)getParm(obj,3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233CalendarioCodigo", A233CalendarioCodigo);
         }
         wcpOA41ClinicaCodigo = cgiGet( sPrefix+"wcpOA41ClinicaCodigo") ;
         wcpOA233CalendarioCodigo = cgiGet( sPrefix+"wcpOA233CalendarioCodigo") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A41ClinicaCodigo, wcpOA41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, wcpOA233CalendarioCodigo) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOA41ClinicaCodigo = A41ClinicaCodigo ;
         wcpOA233CalendarioCodigo = A233CalendarioCodigo ;
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
         sCtrlA233CalendarioCodigo = cgiGet( sPrefix+"A233CalendarioCodigo_CTRL") ;
         if ( StringUtil.Len( sCtrlA233CalendarioCodigo) > 0 )
         {
            A233CalendarioCodigo = cgiGet( sCtrlA233CalendarioCodigo) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233CalendarioCodigo", A233CalendarioCodigo);
         }
         else
         {
            A233CalendarioCodigo = cgiGet( sPrefix+"A233CalendarioCodigo_PARM") ;
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
         PA2F2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS2F2( ) ;
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
         WS2F2( ) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"A233CalendarioCodigo_PARM", StringUtil.RTrim( A233CalendarioCodigo));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA233CalendarioCodigo)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A233CalendarioCodigo_CTRL", StringUtil.RTrim( sCtrlA233CalendarioCodigo));
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
         WE2F2( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?15213955");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("calendariogeneral.js", "?15213955");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = sPrefix+"TEXTBLOCKCLINICACODIGO" ;
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO" ;
         lblTextblockcalendariocodigo_Internalname = sPrefix+"TEXTBLOCKCALENDARIOCODIGO" ;
         edtCalendarioCodigo_Internalname = sPrefix+"CALENDARIOCODIGO" ;
         lblTextblockcalendarioobs_Internalname = sPrefix+"TEXTBLOCKCALENDARIOOBS" ;
         edtCalendarioObs_Internalname = sPrefix+"CALENDARIOOBS" ;
         lblTextblockpacienteid_Internalname = sPrefix+"TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = sPrefix+"PACIENTEID" ;
         lblTextblockcalendarioinicio_Internalname = sPrefix+"TEXTBLOCKCALENDARIOINICIO" ;
         edtCalendarioInicio_Internalname = sPrefix+"CALENDARIOINICIO" ;
         lblTextblockcalendariofinal_Internalname = sPrefix+"TEXTBLOCKCALENDARIOFINAL" ;
         edtCalendarioFinal_Internalname = sPrefix+"CALENDARIOFINAL" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtCalendarioFinal_Jsonclick = "" ;
         edtCalendarioInicio_Jsonclick = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtCalendarioCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
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
         wcpOA233CalendarioCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV15Pgmname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtnupdate_Jsonclick = "" ;
         bttBtndelete_Jsonclick = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXDecQS = "" ;
         scmdbuf = "" ;
         H002F2_A41ClinicaCodigo = new String[] {""} ;
         H002F2_A233CalendarioCodigo = new String[] {""} ;
         H002F2_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         H002F2_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         H002F2_A67PacienteId = new int[1] ;
         H002F2_A234CalendarioObs = new String[] {""} ;
         A236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
         A235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         A234CalendarioObs = "" ;
         AV9TrnContext = new SdtTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7ClinicaCodigo = "" ;
         AV8CalendarioCodigo = "" ;
         AV11Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockcalendariocodigo_Jsonclick = "" ;
         lblTextblockcalendarioobs_Jsonclick = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockcalendarioinicio_Jsonclick = "" ;
         lblTextblockcalendariofinal_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA41ClinicaCodigo = "" ;
         sCtrlA233CalendarioCodigo = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calendariogeneral__default(),
            new Object[][] {
                new Object[] {
               H002F2_A41ClinicaCodigo, H002F2_A233CalendarioCodigo, H002F2_A236CalendarioFinal, H002F2_A235CalendarioInicio, H002F2_A67PacienteId, H002F2_A234CalendarioObs
               }
            }
         );
         AV15Pgmname = "CalendarioGeneral" ;
         /* GeneXus formulas. */
         AV15Pgmname = "CalendarioGeneral" ;
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
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int A67PacienteId ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV15Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXDecQS ;
      private String scmdbuf ;
      private String edtCalendarioObs_Internalname ;
      private String edtPacienteId_Internalname ;
      private String edtCalendarioInicio_Internalname ;
      private String edtCalendarioFinal_Internalname ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtClinicaCodigo_Internalname ;
      private String edtClinicaCodigo_Jsonclick ;
      private String lblTextblockcalendariocodigo_Internalname ;
      private String lblTextblockcalendariocodigo_Jsonclick ;
      private String edtCalendarioCodigo_Internalname ;
      private String edtCalendarioCodigo_Jsonclick ;
      private String lblTextblockcalendarioobs_Internalname ;
      private String lblTextblockcalendarioobs_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Jsonclick ;
      private String lblTextblockcalendarioinicio_Internalname ;
      private String lblTextblockcalendarioinicio_Jsonclick ;
      private String edtCalendarioInicio_Jsonclick ;
      private String lblTextblockcalendariofinal_Internalname ;
      private String lblTextblockcalendariofinal_Jsonclick ;
      private String edtCalendarioFinal_Jsonclick ;
      private String sCtrlA41ClinicaCodigo ;
      private String sCtrlA233CalendarioCodigo ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private DateTime A236CalendarioFinal ;
      private DateTime A235CalendarioInicio ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A41ClinicaCodigo ;
      private String A233CalendarioCodigo ;
      private String wcpOA41ClinicaCodigo ;
      private String wcpOA233CalendarioCodigo ;
      private String A234CalendarioObs ;
      private String AV7ClinicaCodigo ;
      private String AV8CalendarioCodigo ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002F2_A41ClinicaCodigo ;
      private String[] H002F2_A233CalendarioCodigo ;
      private DateTime[] H002F2_A236CalendarioFinal ;
      private DateTime[] H002F2_A235CalendarioInicio ;
      private int[] H002F2_A67PacienteId ;
      private String[] H002F2_A234CalendarioObs ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private GxWebSession AV11Session ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class calendariogeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002F2 ;
          prmH002F2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002F2", "SELECT [ClinicaCodigo], [CalendarioCodigo], [CalendarioFinal], [CalendarioInicio], [PacienteId], [CalendarioObs] FROM [Calendario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CalendarioCodigo] = @CalendarioCodigo ORDER BY [ClinicaCodigo], [CalendarioCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002F2,1,0,true,true )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
