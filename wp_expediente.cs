/*
               File: wp_expediente
        Description: Consulta de Expedientes Médicos Físicos
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:47.18
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
   public class wp_expediente : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_expediente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_expediente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_PacienteId )
      {
         this.AV7PacienteId = aP0_PacienteId;
         executePrivate();
         aP0_PacienteId=this.AV7PacienteId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPacientegenero = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               cmbavPacientegenero.Name = "vPACIENTEGENERO" ;
               cmbavPacientegenero.WebTags = "" ;
               cmbavPacientegenero.addItem("M", "Masculino", 0);
               cmbavPacientegenero.addItem("F", "Femenino", 0);
               if ( ( cmbavPacientegenero.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8PacienteGenero)) )
               {
                  AV8PacienteGenero = cmbavPacientegenero.getItemValue(1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteGenero", AV8PacienteGenero);
               }
               AV6ClinicaCodigo = GetNextPar( ) ;
               AV7PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( AV6ClinicaCodigo, AV7PacienteId) ;
               return  ;
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
         PA1P2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1P2( ) ;
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
         GXEncryptionTmp = UrlEncode("" +AV7PacienteId) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_expediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV6ClinicaCodigo));
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
            WE1P2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1P2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_expediente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Expedientes Médicos Físicos" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7PacienteId) ;
         return formatLink("wp_expediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void WB1P0( )
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
            wb_table1_2_1P2( true) ;
         }
         else
         {
            wb_table1_2_1P2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1P2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1P2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Consulta de Expedientes Médicos Físicos", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1P0( ) ;
      }

      protected void WS1P2( )
      {
         START1P2( ) ;
         EVT1P2( ) ;
      }

      protected void EVT1P2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111P2 */
                              E111P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MODIFICAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121P2 */
                              E121P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVO EXPEDIENTE'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131P2 */
                              E131P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "'MODIFICAR'") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
                              edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
                              edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_51_idx ;
                              edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_51_idx ;
                              edtExpedienteObs_Internalname = "EXPEDIENTEOBS_"+sGXsfl_51_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
                              A167ExpedienteId = (int)(context.localUtil.CToN( cgiGet( edtExpedienteId_Internalname), ".", ",")) ;
                              A168ExpedienteFecha = context.localUtil.CToD( cgiGet( edtExpedienteFecha_Internalname), 2) ;
                              A176ExpedienteObs = cgiGet( edtExpedienteObs_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141P2 */
                                    E141P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E151P2 */
                                    E151P2 ();
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MODIFICAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121P2 */
                                    E121P2 ();
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
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1P2( )
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

      protected void PA1P2( )
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
                  }
               }
            }
            cmbavPacientegenero.Name = "vPACIENTEGENERO" ;
            cmbavPacientegenero.WebTags = "" ;
            cmbavPacientegenero.addItem("M", "Masculino", 0);
            cmbavPacientegenero.addItem("F", "Femenino", 0);
            if ( ( cmbavPacientegenero.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8PacienteGenero)) )
            {
               AV8PacienteGenero = cmbavPacientegenero.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteGenero", AV8PacienteGenero);
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
         edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_51_idx ;
         edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_51_idx ;
         edtExpedienteObs_Internalname = "EXPEDIENTEOBS_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
            edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_51_idx ;
            edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_51_idx ;
            edtExpedienteObs_Internalname = "EXPEDIENTEOBS_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String AV6ClinicaCodigo ,
                                        int AV7PacienteId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF1P2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1P2( ) ;
         /* End function Refresh */
      }

      protected void RF1P2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
         edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_51_idx ;
         edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_51_idx ;
         edtExpedienteObs_Internalname = "EXPEDIENTEOBS_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
            edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_51_idx ;
            edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_51_idx ;
            edtExpedienteObs_Internalname = "EXPEDIENTEOBS_"+sGXsfl_51_idx ;
            /* Using cursor H001P2 */
            pr_default.execute(0, new Object[] {AV6ClinicaCodigo, AV7PacienteId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A176ExpedienteObs = H001P2_A176ExpedienteObs[0] ;
               A168ExpedienteFecha = H001P2_A168ExpedienteFecha[0] ;
               A167ExpedienteId = H001P2_A167ExpedienteId[0] ;
               A67PacienteId = H001P2_A67PacienteId[0] ;
               A41ClinicaCodigo = H001P2_A41ClinicaCodigo[0] ;
               /* Execute user event: E151P2 */
               E151P2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 51 ;
            WB1P0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP1P0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavPacienteid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteid_Enabled), 5, 0)));
         edtavPacientenombre1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenombre1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenombre1_Enabled), 5, 0)));
         edtavPacientenombre2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenombre2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenombre2_Enabled), 5, 0)));
         edtavPacienteapellido1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteapellido1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteapellido1_Enabled), 5, 0)));
         edtavPacienteapellido2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteapellido2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteapellido2_Enabled), 5, 0)));
         edtavPacienteapellido3_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteapellido3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteapellido3_Enabled), 5, 0)));
         cmbavPacientegenero.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPacientegenero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavPacientegenero.Enabled), 5, 0)));
         edtavPacientenacimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenacimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenacimiento_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E141P2 */
         E141P2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV10PacienteNombre1 = cgiGet( edtavPacientenombre1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteNombre1", AV10PacienteNombre1);
            AV11PacienteNombre2 = cgiGet( edtavPacientenombre2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteNombre2", AV11PacienteNombre2);
            AV12PacienteApellido1 = cgiGet( edtavPacienteapellido1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PacienteApellido1", AV12PacienteApellido1);
            AV13PacienteApellido2 = cgiGet( edtavPacienteapellido2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteApellido2", AV13PacienteApellido2);
            AV14PacienteApellido3 = cgiGet( edtavPacienteapellido3_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PacienteApellido3", AV14PacienteApellido3);
            AV9PacienteNacimiento = context.localUtil.CToD( cgiGet( edtavPacientenacimiento_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteNacimiento", context.localUtil.Format(AV9PacienteNacimiento, "99/99/99"));
            cmbavPacientegenero.Name = cmbavPacientegenero_Internalname ;
            cmbavPacientegenero.CurrentValue = cgiGet( cmbavPacientegenero_Internalname) ;
            AV8PacienteGenero = cgiGet( cmbavPacientegenero_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteGenero", AV8PacienteGenero);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
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
         /* Execute user event: E141P2 */
         E141P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141P2( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV5Parametros = GXt_SdtParametros3 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         new pobtieneinfopaciente(context ).execute( ref  AV6ClinicaCodigo, ref  AV7PacienteId, ref  AV10PacienteNombre1, ref  AV11PacienteNombre2, ref  AV12PacienteApellido1, ref  AV13PacienteApellido2, ref  AV14PacienteApellido3, ref  AV8PacienteGenero, ref  AV9PacienteNacimiento, ref  AV15ConsultaEdad) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteNombre1", AV10PacienteNombre1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteNombre2", AV11PacienteNombre2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PacienteApellido1", AV12PacienteApellido1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteApellido2", AV13PacienteApellido2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PacienteApellido3", AV14PacienteApellido3);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteGenero", AV8PacienteGenero);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteNacimiento", context.localUtil.Format(AV9PacienteNacimiento, "99/99/99"));
      }

      protected void E111P2( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("wp_paciente_emf.aspx")  ;
      }

      protected void E121P2( )
      {
         /* 'Modificar' Routine */
         if ( A167ExpedienteId > 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode("" +AV7PacienteId) + "," + UrlEncode("" +A167ExpedienteId) ;
            context.wjLoc = formatLink("wp_registraexpediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         }
         else
         {
            GX_msglist.addItem("Debe seleccionar un expediente válido.");
         }
      }

      protected void E131P2( )
      {
         /* 'Nuevo Expediente' Routine */
         GXt_int4 = AV16ExpedienteId ;
         new oobtienecorrelativo(context ).execute(  AV6ClinicaCodigo,  7, out  GXt_int4) ;
         AV16ExpedienteId = GXt_int4 ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7PacienteId) + "," + UrlEncode("" +AV16ExpedienteId) ;
         context.wjLoc = formatLink("wp_registraexpediente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      private void E151P2( )
      {
         /* Load Routine */
         sendrow_512( ) ;
      }

      protected void wb_table1_2_1P2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Expedientes Médicos Físicos", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
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
            context.WriteHtmlText( "<td>") ;
            wb_table2_11_1P2( true) ;
         }
         else
         {
            wb_table2_11_1P2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1P2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:126px\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"51\">") ;
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Paciente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Expediente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Observaciones") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid1_Titlefont));
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A176ExpedienteObs));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:25px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Nuevo Expediente", bttButton1_Jsonclick, 5, "Nuevo Expediente", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVO EXPEDIENTE\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_expediente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Regresar", bttButton2_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1P2e( true) ;
         }
         else
         {
            wb_table1_2_1P2e( false) ;
         }
      }

      protected void wb_table2_11_1P2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Paciente Id", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PacienteId), 9, 0, ".", "")), ((edtavPacienteid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7PacienteId), "ZZZZZZZZ9")), "", "", "", "", "", edtavPacienteid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, "Primer Nombre", "", "", lblTextblock16_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteNombre1", AV10PacienteNombre1);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombre1_Internalname, StringUtil.RTrim( AV10PacienteNombre1), StringUtil.RTrim( context.localUtil.Format( AV10PacienteNombre1, "")), "", "", "", "", "", edtavPacientenombre1_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenombre1_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, "Segundo Nombre", "", "", lblTextblock15_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteNombre2", AV11PacienteNombre2);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombre2_Internalname, StringUtil.RTrim( AV11PacienteNombre2), StringUtil.RTrim( context.localUtil.Format( AV11PacienteNombre2, "")), "", "", "", "", "", edtavPacientenombre2_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenombre2_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, "Primer Apellido", "", "", lblTextblock12_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PacienteApellido1", AV12PacienteApellido1);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido1_Internalname, StringUtil.RTrim( AV12PacienteApellido1), StringUtil.RTrim( context.localUtil.Format( AV12PacienteApellido1, "")), "", "", "", "", "", edtavPacienteapellido1_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteapellido1_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, "Segundo Nombre", "", "", lblTextblock13_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteApellido2", AV13PacienteApellido2);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido2_Internalname, StringUtil.RTrim( AV13PacienteApellido2), StringUtil.RTrim( context.localUtil.Format( AV13PacienteApellido2, "")), "", "", "", "", "", edtavPacienteapellido2_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteapellido2_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, "Apellido de Casada", "", "", lblTextblock14_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PacienteApellido3", AV14PacienteApellido3);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido3_Internalname, StringUtil.RTrim( AV14PacienteApellido3), StringUtil.RTrim( context.localUtil.Format( AV14PacienteApellido3, "")), "", "", "", "", "", edtavPacienteapellido3_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteapellido3_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Fecha Nac.", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteNacimiento", context.localUtil.Format(AV9PacienteNacimiento, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavPacientenacimiento_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenacimiento_Internalname, context.localUtil.Format(AV9PacienteNacimiento, "99/99/99"), context.localUtil.Format( AV9PacienteNacimiento, "99/99/99"), "", "", "", "", "", edtavPacientenacimiento_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenacimiento_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_expediente.htm");
            GxWebStd.gx_bitmap( context, edtavPacientenacimiento_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavPacientenacimiento_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_expediente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Genero", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteGenero", AV8PacienteGenero);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPacientegenero, cmbavPacientegenero_Internalname, AV8PacienteGenero, 1, cmbavPacientegenero_Jsonclick, 0, "", "svchar", "", 1, cmbavPacientegenero.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, "", "", true, "HLP_wp_expediente.htm");
            cmbavPacientegenero.CurrentValue = AV8PacienteGenero ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPacientegenero_Internalname, "Values", (String)(cmbavPacientegenero.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1P2e( true) ;
         }
         else
         {
            wb_table2_11_1P2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7PacienteId = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PacienteId), 9, 0)));
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
         PA1P2( ) ;
         WS1P2( ) ;
         WE1P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1574778");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_expediente.js", "?1574778");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB1P0( ) ;
         Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            subGrid1_Backcolor = subGrid1_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
            subGrid1_Backcolor = (int)(0x0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even" ;
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
         }
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_51_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A167ExpedienteId), "ZZZZZZZZ9"),(String)"","E\\'MODIFICAR\\'."+sGXsfl_51_idx,(String)"",(String)"",(String)"",(String)edtExpedienteId_Jsonclick,(short)5,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteFecha_Internalname,context.localUtil.Format(A168ExpedienteFecha, "99/99/99"),context.localUtil.Format( A168ExpedienteFecha, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteObs_Internalname,StringUtil.RTrim( A176ExpedienteObs),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteObs_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)600,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
         edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_51_idx ;
         edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_51_idx ;
         edtExpedienteObs_Internalname = "EXPEDIENTEOBS_"+sGXsfl_51_idx ;
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavPacienteid_Internalname = "vPACIENTEID" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtavPacientenombre1_Internalname = "vPACIENTENOMBRE1" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         edtavPacientenombre2_Internalname = "vPACIENTENOMBRE2" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtavPacienteapellido1_Internalname = "vPACIENTEAPELLIDO1" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtavPacienteapellido2_Internalname = "vPACIENTEAPELLIDO2" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtavPacienteapellido3_Internalname = "vPACIENTEAPELLIDO3" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtavPacientenacimiento_Internalname = "vPACIENTENACIMIENTO" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         cmbavPacientegenero_Internalname = "vPACIENTEGENERO" ;
         tblTable4_Internalname = "TABLE4" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtExpedienteObs_Jsonclick = "" ;
         edtExpedienteFecha_Jsonclick = "" ;
         edtExpedienteId_Jsonclick = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         cmbavPacientegenero_Jsonclick = "" ;
         cmbavPacientegenero.Enabled = 0 ;
         edtavPacientenacimiento_Jsonclick = "" ;
         edtavPacientenacimiento_Enabled = 0 ;
         edtavPacienteapellido3_Jsonclick = "" ;
         edtavPacienteapellido3_Enabled = 0 ;
         edtavPacienteapellido2_Jsonclick = "" ;
         edtavPacienteapellido2_Enabled = 0 ;
         edtavPacienteapellido1_Jsonclick = "" ;
         edtavPacienteapellido1_Enabled = 0 ;
         edtavPacientenombre2_Jsonclick = "" ;
         edtavPacientenombre2_Enabled = 0 ;
         edtavPacientenombre1_Jsonclick = "" ;
         edtavPacientenombre1_Enabled = 0 ;
         edtavPacienteid_Jsonclick = "" ;
         edtavPacienteid_Enabled = 0 ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de Expedientes Médicos Físicos" ;
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
         AV8PacienteGenero = "" ;
         AV6ClinicaCodigo = "" ;
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
         edtClinicaCodigo_Internalname = "" ;
         edtPacienteId_Internalname = "" ;
         edtExpedienteId_Internalname = "" ;
         edtExpedienteFecha_Internalname = "" ;
         edtExpedienteObs_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A168ExpedienteFecha = DateTime.MinValue ;
         A176ExpedienteObs = "" ;
         GXDecQS = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H001P2_A176ExpedienteObs = new String[] {""} ;
         H001P2_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         H001P2_A167ExpedienteId = new int[1] ;
         H001P2_A67PacienteId = new int[1] ;
         H001P2_A41ClinicaCodigo = new String[] {""} ;
         AV10PacienteNombre1 = "" ;
         AV11PacienteNombre2 = "" ;
         AV12PacienteApellido1 = "" ;
         AV13PacienteApellido2 = "" ;
         AV14PacienteApellido3 = "" ;
         AV9PacienteNacimiento = DateTime.MinValue ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock16_Jsonclick = "" ;
         lblTextblock15_Jsonclick = "" ;
         lblTextblock12_Jsonclick = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock14_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_expediente__default(),
            new Object[][] {
                new Object[] {
               H001P2_A176ExpedienteObs, H001P2_A168ExpedienteFecha, H001P2_A167ExpedienteId, H001P2_A67PacienteId, H001P2_A41ClinicaCodigo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short AV15ConsultaEdad ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV7PacienteId ;
      private int wcpOAV7PacienteId ;
      private int A67PacienteId ;
      private int A167ExpedienteId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int edtavPacienteid_Enabled ;
      private int edtavPacientenombre1_Enabled ;
      private int edtavPacientenombre2_Enabled ;
      private int edtavPacienteapellido1_Enabled ;
      private int edtavPacienteapellido2_Enabled ;
      private int edtavPacienteapellido3_Enabled ;
      private int edtavPacientenacimiento_Enabled ;
      private int AV16ExpedienteId ;
      private int GXt_int4 ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
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
      private String edtClinicaCodigo_Internalname ;
      private String edtPacienteId_Internalname ;
      private String edtExpedienteId_Internalname ;
      private String edtExpedienteFecha_Internalname ;
      private String edtExpedienteObs_Internalname ;
      private String GXDecQS ;
      private String scmdbuf ;
      private String edtavPacienteid_Internalname ;
      private String edtavPacientenombre1_Internalname ;
      private String edtavPacientenombre2_Internalname ;
      private String edtavPacienteapellido1_Internalname ;
      private String edtavPacienteapellido2_Internalname ;
      private String edtavPacienteapellido3_Internalname ;
      private String cmbavPacientegenero_Internalname ;
      private String edtavPacientenacimiento_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char5 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String GXt_char6 ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavPacienteid_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtavPacientenombre1_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String edtavPacientenombre2_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtavPacienteapellido1_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtavPacienteapellido2_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtavPacienteapellido3_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavPacientenacimiento_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String cmbavPacientegenero_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtPacienteId_Jsonclick ;
      private String edtExpedienteId_Jsonclick ;
      private String edtExpedienteFecha_Jsonclick ;
      private String edtExpedienteObs_Jsonclick ;
      private String GXt_char8 ;
      private DateTime A168ExpedienteFecha ;
      private DateTime AV9PacienteNacimiento ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV8PacienteGenero ;
      private String AV6ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A176ExpedienteObs ;
      private String AV10PacienteNombre1 ;
      private String AV11PacienteNombre2 ;
      private String AV12PacienteApellido1 ;
      private String AV13PacienteApellido2 ;
      private String AV14PacienteApellido3 ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private int aP0_PacienteId ;
      private GXCombobox cmbavPacientegenero ;
      private IDataStoreProvider pr_default ;
      private String[] H001P2_A176ExpedienteObs ;
      private DateTime[] H001P2_A168ExpedienteFecha ;
      private int[] H001P2_A167ExpedienteId ;
      private int[] H001P2_A67PacienteId ;
      private String[] H001P2_A41ClinicaCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class wp_expediente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001P2 ;
          prmH001P2 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7PacienteId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001P2", "SELECT [ExpedienteObs], [ExpedienteFecha], [ExpedienteId], [PacienteId], [ClinicaCodigo] FROM [Expediente] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV6ClinicaCodigo) AND ([PacienteId] = @AV7PacienteId) ORDER BY [ClinicaCodigo], [ExpedienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P2,11,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
