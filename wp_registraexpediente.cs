/*
               File: wp_registraexpediente
        Description: Registra Expediente Médico Físico de Paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:48.61
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
   public class wp_registraexpediente : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_registraexpediente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_registraexpediente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_PacienteId ,
                           ref int aP1_ExpedienteId )
      {
         this.AV7PacienteId = aP0_PacienteId;
         this.AV8ExpedienteId = aP1_ExpedienteId;
         executePrivate();
         aP0_PacienteId=this.AV7PacienteId;
         aP1_ExpedienteId=this.AV8ExpedienteId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            if ( ! entryPointCalled )
            {
               AV7PacienteId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8ExpedienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
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
         PA1S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1S2( ) ;
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
         context.AddJavascriptSource("calendar.js", "?58720");
         context.AddJavascriptSource("calendar-setup.js", "?58720");
         context.AddJavascriptSource("calendar-es.js", "?58720");
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
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7PacienteId) + "," + UrlEncode("" +AV8ExpedienteId) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_registraexpediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
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
            WE1S2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1S2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_registraexpediente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Registra Expediente Médico Físico de Paciente" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7PacienteId) + "," + UrlEncode("" +AV8ExpedienteId) ;
         return formatLink("wp_registraexpediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void WB1S0( )
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
            wb_table1_2_1S2( true) ;
         }
         else
         {
            wb_table1_2_1S2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1S2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1S2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Registra Expediente Médico Físico de Paciente", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1S0( ) ;
      }

      protected void WS1S2( )
      {
         START1S2( ) ;
         EVT1S2( ) ;
      }

      protected void EVT1S2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111S2 */
                              E111S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GUARDAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121S2 */
                              E121S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'FINALIZAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131S2 */
                              E131S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E141S2 */
                              E141S2 ();
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

      protected void WE1S2( )
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

      protected void PA1S2( )
      {
         if ( nDonePA == 0 )
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
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( nGotPars == 0 )
               {
                  entryPointCalled = false ;
                  gxfirstwebparm = GetNextPar( ) ;
                  if ( ! entryPointCalled )
                  {
                     AV7PacienteId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
                     if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
                     {
                        AV8ExpedienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
                     }
                  }
               }
            }
            GX_FocusControl = edtavExpedienteobs_Internalname ;
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
         RF1S2( ) ;
         /* End function Refresh */
      }

      protected void RF1S2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E141S2 */
            E141S2 ();
            WB1S0( ) ;
         }
      }

      protected void STRUP1S0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavPacienteid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteid_Enabled), 5, 0)));
         edtavExpedientefecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavExpedientefecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavExpedientefecha_Enabled), 5, 0)));
         edtavExpedientehora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavExpedientehora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavExpedientehora_Enabled), 5, 0)));
         edtavExpedienteid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavExpedienteid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavExpedienteid_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111S2 */
         E111S2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV9ExpedienteFecha = context.localUtil.CToD( cgiGet( edtavExpedientefecha_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ExpedienteFecha", context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"));
            AV10ExpedienteHora = cgiGet( edtavExpedientehora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ExpedienteHora", AV10ExpedienteHora);
            AV11ExpedienteObs = cgiGet( edtavExpedienteobs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ExpedienteObs", AV11ExpedienteObs);
            AV13ExpedienteDescripcion = cgiGet( edtavExpedientedescripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExpedienteDescripcion", AV13ExpedienteDescripcion);
            AV14ExpedienteArchivo = cgiGet( edtavExpedientearchivo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ExpedienteArchivo", AV14ExpedienteArchivo);
            /* Read saved values. */
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
         /* Execute user event: E111S2 */
         E111S2 ();
         if (returnInSub) return;
      }

      protected void E111S2( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV5Parametros = GXt_SdtParametros3 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         AV12UsuarioCodigo = AV5Parametros.gxTpr_Pusuariocodigo ;
         new oobtieneexpediente(context ).execute( ref  AV6ClinicaCodigo, ref  AV8ExpedienteId, ref  AV9ExpedienteFecha, ref  AV10ExpedienteHora, ref  AV11ExpedienteObs, ref  AV15Flag) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ExpedienteFecha", context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ExpedienteHora", AV10ExpedienteHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ExpedienteObs", AV11ExpedienteObs);
         if ( AV15Flag == 0 )
         {
            AV9ExpedienteFecha = Gx_date ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ExpedienteFecha", context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"));
            AV10ExpedienteHora = Gx_time ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ExpedienteHora", AV10ExpedienteHora);
         }
         new pregistraexpediente(context ).execute( ref  AV6ClinicaCodigo, ref  AV7PacienteId, ref  AV8ExpedienteId, ref  AV9ExpedienteFecha, ref  AV10ExpedienteHora, ref  AV11ExpedienteObs, ref  AV12UsuarioCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ExpedienteFecha", context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ExpedienteHora", AV10ExpedienteHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ExpedienteObs", AV11ExpedienteObs);
      }

      protected void E121S2( )
      {
         /* 'Guardar' Routine */
         new pregistraexpedientedet(context ).execute( ref  AV6ClinicaCodigo, ref  AV8ExpedienteId, ref  AV14ExpedienteArchivo, ref  AV13ExpedienteDescripcion, ref  AV12UsuarioCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ExpedienteArchivo", AV14ExpedienteArchivo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExpedienteDescripcion", AV13ExpedienteDescripcion);
         GX_msglist.addItem("Documento almacenado exitosamente.");
         AV14ExpedienteArchivo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ExpedienteArchivo", AV14ExpedienteArchivo);
         AV13ExpedienteDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExpedienteDescripcion", AV13ExpedienteDescripcion);
      }

      protected void E131S2( )
      {
         /* 'Finalizar' Routine */
         new pregistraexpediente(context ).execute( ref  AV6ClinicaCodigo, ref  AV7PacienteId, ref  AV8ExpedienteId, ref  AV9ExpedienteFecha, ref  AV10ExpedienteHora, ref  AV11ExpedienteObs, ref  AV12UsuarioCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ExpedienteFecha", context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ExpedienteHora", AV10ExpedienteHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ExpedienteObs", AV11ExpedienteObs);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7PacienteId) ;
         context.wjLoc = formatLink("wp_expediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E141S2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_1S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Registro de Expediente Médico Físico", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:16px\">") ;
            wb_table2_11_1S2( true) ;
         }
         else
         {
            wb_table2_11_1S2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:16px\">") ;
            wb_table3_32_1S2( true) ;
         }
         else
         {
            wb_table3_32_1S2( false) ;
         }
         return  ;
      }

      protected void wb_table3_32_1S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table4_40_1S2( true) ;
         }
         else
         {
            wb_table4_40_1S2( false) ;
         }
         return  ;
      }

      protected void wb_table4_40_1S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Finalizar", bttButton2_Jsonclick, 5, "Finalizar", "", StyleString, ClassString, 1, 1, "standard", "E\\'FINALIZAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1S2e( true) ;
         }
         else
         {
            wb_table1_2_1S2e( false) ;
         }
      }

      protected void wb_table4_40_1S2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Descripción", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExpedienteDescripcion", AV13ExpedienteDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavExpedientedescripcion_Internalname, StringUtil.RTrim( AV13ExpedienteDescripcion), StringUtil.RTrim( context.localUtil.Format( AV13ExpedienteDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(45);\"", "", "", "", "", edtavExpedientedescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Archivo", "", "", lblTextblock10_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Image" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"" ;
            edtavExpedientearchivo_Filetype = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavExpedientearchivo_Internalname, "Filetype", edtavExpedientearchivo_Filetype);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14ExpedienteArchivo)) )
            {
               gxblobfileaux.Source = AV14ExpedienteArchivo ;
               gxblobfileaux.SetExtension(StringUtil.Trim( edtavExpedientearchivo_Filetype));
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  AV14ExpedienteArchivo = gxblobfileaux.GetAbsoluteName() ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ExpedienteArchivo", AV14ExpedienteArchivo);
               }
            }
            GxWebStd.gx_blob_field( context, edtavExpedientearchivo_Internalname, StringUtil.RTrim( AV14ExpedienteArchivo), context.PathToRelativeUrl( AV14ExpedienteArchivo), (String.IsNullOrEmpty(StringUtil.RTrim( edtavExpedientearchivo_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtavExpedientearchivo_Filetype)) ? AV14ExpedienteArchivo : edtavExpedientearchivo_Filetype)) : edtavExpedientearchivo_Contenttype), false, "", edtavExpedientearchivo_Parameters, 0, 1, 1, "", "", 0, -1, 250, "px", 60, "px", 0, 0, 0, edtavExpedientearchivo_Jsonclick, "", StyleString, ClassString, ""+TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(51);\"", "", "HLP_wp_registraexpediente.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavExpedientearchivo_Internalname, "URL", context.PathToRelativeUrl( AV14ExpedienteArchivo));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Guardar", bttButton1_Jsonclick, 5, "Guardar", "", StyleString, ClassString, 1, 1, "standard", "E\\'GUARDAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_40_1S2e( true) ;
         }
         else
         {
            wb_table4_40_1S2e( false) ;
         }
      }

      protected void wb_table3_32_1S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Observaciones", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ExpedienteObs", AV11ExpedienteObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavExpedienteobs_Internalname, StringUtil.RTrim( AV11ExpedienteObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(37);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_32_1S2e( true) ;
         }
         else
         {
            wb_table3_32_1S2e( false) ;
         }
      }

      protected void wb_table2_11_1S2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Paciente Id", "", "", lblTextblock8_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PacienteId), 9, 0, ".", "")), ((edtavPacienteid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7PacienteId), "ZZZZZZZZ9")), "", "", "", "", "", edtavPacienteid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Expediente Id", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavExpedienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ExpedienteId), 9, 0, ".", "")), ((edtavExpedienteid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8ExpedienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8ExpedienteId), "ZZZZZZZZ9")), "", "", "", "", "", edtavExpedienteid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavExpedienteid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Fecha", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ExpedienteFecha", context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavExpedientefecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavExpedientefecha_Internalname, context.localUtil.Format(AV9ExpedienteFecha, "99/99/99"), context.localUtil.Format( AV9ExpedienteFecha, "99/99/99"), "", "", "", "", "", edtavExpedientefecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtavExpedientefecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraexpediente.htm");
            GxWebStd.gx_bitmap( context, edtavExpedientefecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavExpedientefecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_registraexpediente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Hora", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ExpedienteHora", AV10ExpedienteHora);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavExpedientehora_Internalname, StringUtil.RTrim( AV10ExpedienteHora), StringUtil.RTrim( context.localUtil.Format( AV10ExpedienteHora, "XXXXXXXX")), "", "", "", "", "", edtavExpedientehora_Jsonclick, 0, ClassString, StyleString, "", 1, edtavExpedientehora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraexpediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1S2e( true) ;
         }
         else
         {
            wb_table2_11_1S2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7PacienteId = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
         AV8ExpedienteId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ExpedienteId), 9, 0)));
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
         PA1S2( ) ;
         WS1S2( ) ;
         WE1S2( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1574899");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_registraexpediente.js", "?1574899");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtavPacienteid_Internalname = "vPACIENTEID" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavExpedienteid_Internalname = "vEXPEDIENTEID" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavExpedientefecha_Internalname = "vEXPEDIENTEFECHA" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavExpedientehora_Internalname = "vEXPEDIENTEHORA" ;
         tblTable2_Internalname = "TABLE2" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtavExpedienteobs_Internalname = "vEXPEDIENTEOBS" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtavExpedientedescripcion_Internalname = "vEXPEDIENTEDESCRIPCION" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtavExpedientearchivo_Internalname = "vEXPEDIENTEARCHIVO" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable4_Internalname = "TABLE4" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavExpedientehora_Jsonclick = "" ;
         edtavExpedientehora_Enabled = 0 ;
         edtavExpedientefecha_Jsonclick = "" ;
         edtavExpedientefecha_Enabled = 0 ;
         edtavExpedienteid_Jsonclick = "" ;
         edtavExpedienteid_Enabled = 0 ;
         edtavPacienteid_Jsonclick = "" ;
         edtavPacienteid_Enabled = 0 ;
         edtavExpedientearchivo_Jsonclick = "" ;
         edtavExpedientearchivo_Parameters = "" ;
         edtavExpedientearchivo_Contenttype = "" ;
         edtavExpedientearchivo_Filetype = "" ;
         edtavExpedientedescripcion_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Registra Expediente Médico Físico de Paciente" ;
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
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXDecQS = "" ;
         Gx_time = "" ;
         Gx_date = DateTime.MinValue ;
         AV9ExpedienteFecha = DateTime.MinValue ;
         AV10ExpedienteHora = "" ;
         AV11ExpedienteObs = "" ;
         AV13ExpedienteDescripcion = "" ;
         AV14ExpedienteArchivo = "" ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         AV6ClinicaCodigo = "" ;
         AV12UsuarioCodigo = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         bttButton1_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         lblTextblock6_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short AV15Flag ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int AV7PacienteId ;
      private int AV8ExpedienteId ;
      private int wcpOAV7PacienteId ;
      private int wcpOAV8ExpedienteId ;
      private int edtavPacienteid_Enabled ;
      private int edtavExpedientefecha_Enabled ;
      private int edtavExpedientehora_Enabled ;
      private int edtavExpedienteid_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXDecQS ;
      private String edtavExpedienteobs_Internalname ;
      private String Gx_time ;
      private String edtavPacienteid_Internalname ;
      private String edtavExpedientefecha_Internalname ;
      private String edtavExpedientehora_Internalname ;
      private String edtavExpedienteid_Internalname ;
      private String AV10ExpedienteHora ;
      private String edtavExpedientedescripcion_Internalname ;
      private String edtavExpedientearchivo_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavExpedientedescripcion_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtavExpedientearchivo_Filetype ;
      private String edtavExpedientearchivo_Contenttype ;
      private String edtavExpedientearchivo_Parameters ;
      private String edtavExpedientearchivo_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtavPacienteid_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavExpedienteid_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String GXt_char2 ;
      private String edtavExpedientefecha_Jsonclick ;
      private String GXt_char1 ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavExpedientehora_Jsonclick ;
      private DateTime Gx_date ;
      private DateTime AV9ExpedienteFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV11ExpedienteObs ;
      private String AV13ExpedienteDescripcion ;
      private String AV6ClinicaCodigo ;
      private String AV12UsuarioCodigo ;
      private String AV14ExpedienteArchivo ;
      private GxFile gxblobfileaux ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private int aP0_PacienteId ;
      private int aP1_ExpedienteId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

}
