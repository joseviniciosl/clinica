/*
               File: AppointmentGeneral
        Description: Appointment General
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/8/2019 21:35:27.19
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
   public class appointmentgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public appointmentgeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public appointmentgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_AppointmentCode )
      {
         this.A240AppointmentCode = aP0_AppointmentCode;
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
                  A240AppointmentCode = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240AppointmentCode", A240AppointmentCode);
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A240AppointmentCode});
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
            PA2J2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV14Pgmname = "AppointmentGeneral" ;
               context.Gx_err = 0 ;
               WS2J2( ) ;
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
            context.WriteHtmlText( "Appointment General") ;
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
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(A240AppointmentCode)) ;
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("appointmentgeneral.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm2J2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA240AppointmentCode", StringUtil.RTrim( wcpOA240AppointmentCode));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("appointmentgeneral.js", "?21352727");
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

      protected void WB2J0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "appointmentgeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_2J2( true) ;
         }
         else
         {
            wb_table1_2_2J2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2J2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Modifica", bttBtnupdate_Jsonclick, 5, "Modifica", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", context.GetButtonType( ), "HLP_AppointmentGeneral.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Eliminar", bttBtndelete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'DODELETE\\'.", TempTags, "", context.GetButtonType( ), "HLP_AppointmentGeneral.htm");
         }
         wbLoad = true ;
      }

      protected void START2J2( )
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
            Form.Meta.addItem("Description", "Appointment General", 0) ;
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
               STRUP2J0( ) ;
            }
         }
      }

      protected void WS2J2( )
      {
         START2J2( ) ;
         EVT2J2( ) ;
      }

      protected void EVT2J2( )
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
                                 STRUP2J0( ) ;
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
                                 STRUP2J0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E112J2 */
                                    E112J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2J0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E122J2 */
                                    E122J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2J0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E132J2 */
                                    E132J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2J0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E142J2 */
                                    E142J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2J0( ) ;
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
                                 STRUP2J0( ) ;
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

      protected void WE2J2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2J2( ) ;
            }
         }
      }

      protected void PA2J2( )
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
         RF2J2( ) ;
         /* End function Refresh */
      }

      protected void RF2J2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H002J2 */
            pr_default.execute(0, new Object[] {A240AppointmentCode});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A244AppointmentStartDate = H002J2_A244AppointmentStartDate[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
               A243AppointmentObs = H002J2_A243AppointmentObs[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A243AppointmentObs", A243AppointmentObs);
               A242AppointmentEndDate = H002J2_A242AppointmentEndDate[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
               A67PacienteId = H002J2_A67PacienteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               /* Execute user event: E122J2 */
               E122J2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB2J0( ) ;
         }
      }

      protected void STRUP2J0( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "AppointmentGeneral" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112J2 */
         E112J2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A242AppointmentEndDate = context.localUtil.CToT( cgiGet( edtAppointmentEndDate_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
            A243AppointmentObs = cgiGet( edtAppointmentObs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A243AppointmentObs", A243AppointmentObs);
            A244AppointmentStartDate = context.localUtil.CToT( cgiGet( edtAppointmentStartDate_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
            /* Read saved values. */
            wcpOA240AppointmentCode = cgiGet( sPrefix+"wcpOA240AppointmentCode") ;
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
         /* Execute user event: E112J2 */
         E112J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112J2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV14Pgmname, out  AV5IsAuthorized) ;
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
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV14Pgmname)) ;
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

      protected void E122J2( )
      {
         /* Load Routine */
      }

      protected void E132J2( )
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
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A240AppointmentCode)) ;
         context.wjLoc = formatLink("appointment.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E142J2( )
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
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A240AppointmentCode)) ;
         context.wjLoc = formatLink("appointment.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new SdtTransactionContext(context) ;
         AV8TrnContext.gxTpr_Callerobject = AV14Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV8TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV8TrnContext.gxTpr_Callerurl = AV11HTTPRequest.ScriptName+"?"+AV11HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV8TrnContext.gxTpr_Transactionname = "Appointment" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV9TrnContextAtt.gxTpr_Attributename = "AppointmentCode" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV9TrnContextAtt.gxTpr_Attributevalue = AV7AppointmentCode ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV8TrnContext.gxTpr_Attributes.Add(AV9TrnContextAtt, 0);
         AV10Session.Set("TrnContext", AV8TrnContext.ToXml(false, "TransactionContext", "Clinica"));
      }

      protected void wb_table1_2_2J2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentcode_Internalname, "Cita", "", "", lblTextblockappointmentcode_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240AppointmentCode", A240AppointmentCode);
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAppointmentCode_Internalname, StringUtil.RTrim( A240AppointmentCode), StringUtil.RTrim( context.localUtil.Format( A240AppointmentCode, "")), "", "", "", "", "", edtAppointmentCode_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, 1, true, "left", "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9"), "", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, 1, true, "right", "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentenddate_Internalname, "Finaliza", "", "", lblTextblockappointmentenddate_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtAppointmentEndDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAppointmentEndDate_Internalname, context.localUtil.Format(A242AppointmentEndDate, "99/99/99 99:99"), context.localUtil.Format( A242AppointmentEndDate, "99/99/99 99:99"), "", "", "", "", "", edtAppointmentEndDate_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, 1, true, "right", "HLP_AppointmentGeneral.htm");
            GxWebStd.gx_bitmap( context, edtAppointmentEndDate_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_AppointmentGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentobs_Internalname, "Obs", "", "", lblTextblockappointmentobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A243AppointmentObs", A243AppointmentObs);
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtAppointmentObs_Internalname, StringUtil.RTrim( A243AppointmentObs), "", "", 0, 1, 0, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentstartdate_Internalname, "Inicia", "", "", lblTextblockappointmentstartdate_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppointmentGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtAppointmentStartDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAppointmentStartDate_Internalname, context.localUtil.Format(A244AppointmentStartDate, "99/99/99 99:99"), context.localUtil.Format( A244AppointmentStartDate, "99/99/99 99:99"), "", "", "", "", "", edtAppointmentStartDate_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, 1, true, "right", "HLP_AppointmentGeneral.htm");
            GxWebStd.gx_bitmap( context, edtAppointmentStartDate_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_AppointmentGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2J2e( true) ;
         }
         else
         {
            wb_table1_2_2J2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A240AppointmentCode = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240AppointmentCode", A240AppointmentCode);
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
         PA2J2( ) ;
         WS2J2( ) ;
         WE2J2( ) ;
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
         sCtrlA240AppointmentCode = (String)((String)getParm(obj,0)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA2J2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "appointmentgeneral");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA2J2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A240AppointmentCode = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240AppointmentCode", A240AppointmentCode);
         }
         wcpOA240AppointmentCode = cgiGet( sPrefix+"wcpOA240AppointmentCode") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A240AppointmentCode, wcpOA240AppointmentCode) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOA240AppointmentCode = A240AppointmentCode ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA240AppointmentCode = cgiGet( sPrefix+"A240AppointmentCode_CTRL") ;
         if ( StringUtil.Len( sCtrlA240AppointmentCode) > 0 )
         {
            A240AppointmentCode = cgiGet( sCtrlA240AppointmentCode) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240AppointmentCode", A240AppointmentCode);
         }
         else
         {
            A240AppointmentCode = cgiGet( sPrefix+"A240AppointmentCode_PARM") ;
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
         PA2J2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS2J2( ) ;
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
         WS2J2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A240AppointmentCode_PARM", StringUtil.RTrim( A240AppointmentCode));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA240AppointmentCode)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A240AppointmentCode_CTRL", StringUtil.RTrim( sCtrlA240AppointmentCode));
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
         WE2J2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?21352815");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("appointmentgeneral.js", "?21352815");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockappointmentcode_Internalname = sPrefix+"TEXTBLOCKAPPOINTMENTCODE" ;
         edtAppointmentCode_Internalname = sPrefix+"APPOINTMENTCODE" ;
         lblTextblockpacienteid_Internalname = sPrefix+"TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = sPrefix+"PACIENTEID" ;
         lblTextblockappointmentenddate_Internalname = sPrefix+"TEXTBLOCKAPPOINTMENTENDDATE" ;
         edtAppointmentEndDate_Internalname = sPrefix+"APPOINTMENTENDDATE" ;
         lblTextblockappointmentobs_Internalname = sPrefix+"TEXTBLOCKAPPOINTMENTOBS" ;
         edtAppointmentObs_Internalname = sPrefix+"APPOINTMENTOBS" ;
         lblTextblockappointmentstartdate_Internalname = sPrefix+"TEXTBLOCKAPPOINTMENTSTARTDATE" ;
         edtAppointmentStartDate_Internalname = sPrefix+"APPOINTMENTSTARTDATE" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtAppointmentStartDate_Jsonclick = "" ;
         edtAppointmentEndDate_Jsonclick = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtAppointmentCode_Jsonclick = "" ;
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
         wcpOA240AppointmentCode = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV14Pgmname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
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
         H002J2_A240AppointmentCode = new String[] {""} ;
         H002J2_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         H002J2_A243AppointmentObs = new String[] {""} ;
         H002J2_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         H002J2_A67PacienteId = new int[1] ;
         A244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         A243AppointmentObs = "" ;
         A242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         AV8TrnContext = new SdtTransactionContext(context);
         AV11HTTPRequest = new GxHttpRequest( context);
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7AppointmentCode = "" ;
         AV10Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockappointmentcode_Jsonclick = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockappointmentenddate_Jsonclick = "" ;
         lblTextblockappointmentobs_Jsonclick = "" ;
         lblTextblockappointmentstartdate_Jsonclick = "" ;
         GXt_char2 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA240AppointmentCode = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.appointmentgeneral__default(),
            new Object[][] {
                new Object[] {
               H002J2_A240AppointmentCode, H002J2_A244AppointmentStartDate, H002J2_A243AppointmentObs, H002J2_A242AppointmentEndDate, H002J2_A67PacienteId
               }
            }
         );
         AV14Pgmname = "AppointmentGeneral" ;
         /* GeneXus formulas. */
         AV14Pgmname = "AppointmentGeneral" ;
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
      private String AV14Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
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
      private String edtPacienteId_Internalname ;
      private String edtAppointmentEndDate_Internalname ;
      private String edtAppointmentObs_Internalname ;
      private String edtAppointmentStartDate_Internalname ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockappointmentcode_Internalname ;
      private String lblTextblockappointmentcode_Jsonclick ;
      private String edtAppointmentCode_Internalname ;
      private String edtAppointmentCode_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Jsonclick ;
      private String lblTextblockappointmentenddate_Internalname ;
      private String lblTextblockappointmentenddate_Jsonclick ;
      private String edtAppointmentEndDate_Jsonclick ;
      private String lblTextblockappointmentobs_Internalname ;
      private String lblTextblockappointmentobs_Jsonclick ;
      private String lblTextblockappointmentstartdate_Internalname ;
      private String lblTextblockappointmentstartdate_Jsonclick ;
      private String edtAppointmentStartDate_Jsonclick ;
      private String GXt_char2 ;
      private String sCtrlA240AppointmentCode ;
      private String GXt_char3 ;
      private DateTime A244AppointmentStartDate ;
      private DateTime A242AppointmentEndDate ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A240AppointmentCode ;
      private String wcpOA240AppointmentCode ;
      private String A243AppointmentObs ;
      private String AV7AppointmentCode ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002J2_A240AppointmentCode ;
      private DateTime[] H002J2_A244AppointmentStartDate ;
      private String[] H002J2_A243AppointmentObs ;
      private DateTime[] H002J2_A242AppointmentEndDate ;
      private int[] H002J2_A67PacienteId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV11HTTPRequest ;
      private GxWebSession AV10Session ;
      private SdtTransactionContext AV8TrnContext ;
      private SdtTransactionContext_Attribute AV9TrnContextAtt ;
   }

   public class appointmentgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002J2 ;
          prmH002J2 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002J2", "SELECT [AppointmentCode], [AppointmentStartDate], [AppointmentObs], [AppointmentEndDate], [PacienteId] FROM [Appointment] WITH (NOLOCK) WHERE [AppointmentCode] = @AppointmentCode ORDER BY [AppointmentCode] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002J2,1,0,true,true )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
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
                break;
       }
    }

 }

}
