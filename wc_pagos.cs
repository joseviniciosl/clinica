/*
               File: wc_Pagos
        Description: Pagos de Factura de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:25.84
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
   public class wc_pagos : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wc_pagos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wc_pagos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_FacturaId ,
                           ref int aP2_PacienteId ,
                           ref int aP3_ConsultaId )
      {
         this.AV5ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV6FacturaId = aP1_FacturaId;
         this.AV12PacienteId = aP2_PacienteId;
         this.AV13ConsultaId = aP3_ConsultaId;
         executePrivate();
         aP0_ClinicaCodigo=this.AV5ClinicaCodigo;
         aP1_FacturaId=this.AV6FacturaId;
         aP2_PacienteId=this.AV12PacienteId;
         aP3_ConsultaId=this.AV13ConsultaId;
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
         dynavFormapagocodigo = new GXCombobox();
         cmbavFacturapdetalle = new GXCombobox();
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
                  AV5ClinicaCodigo = GetNextPar( ) ;
                  AV6FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV12PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV13ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV5ClinicaCodigo,(int)AV6FacturaId,(int)AV12PacienteId,(int)AV13ConsultaId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vFORMAPAGOCODIGO") == 0 )
               {
                  AV5ClinicaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  GXDLVvFORMAPAGOCODIGO2R2( AV5ClinicaCodigo) ;
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
                  nGXsfl_38_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_38_idx = GetNextPar( ) ;
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid1_newrow( nRC_Grid1, nGXsfl_38_idx, sGXsfl_38_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  /* GeneXus formulas. */
                  context.Gx_err = 0 ;
                  dynavFormapagocodigo.Name = "vFORMAPAGOCODIGO" ;
                  dynavFormapagocodigo.WebTags = "" ;
                  cmbavFacturapdetalle.Name = "vFACTURAPDETALLE" ;
                  cmbavFacturapdetalle.WebTags = "" ;
                  if ( ( cmbavFacturapdetalle.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10FacturaPDetalle)) )
                  {
                     AV10FacturaPDetalle = cmbavFacturapdetalle.getItemValue(1) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10FacturaPDetalle", AV10FacturaPDetalle);
                  }
                  AV5ClinicaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
                  AV6FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid1_refresh( AV5ClinicaCodigo, AV6FacturaId, sPrefix) ;
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
            PA2R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               GXVvFORMAPAGOCODIGO_html2R2( AV5ClinicaCodigo) ;
               WS2R2( ) ;
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
            context.WriteHtmlText( "Pagos de Factura de Pacientes") ;
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
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV5ClinicaCodigo)) + "," + UrlEncode("" +AV6FacturaId) + "," + UrlEncode("" +AV12PacienteId) + "," + UrlEncode("" +AV13ConsultaId) ;
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wc_pagos.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm2R2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV5ClinicaCodigo", StringUtil.RTrim( wcpOAV5ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV6FacturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV6FacturaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV12PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV12PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV13ConsultaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV13ConsultaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vFACTURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6FacturaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vCLINICACODIGO", StringUtil.RTrim( AV5ClinicaCodigo));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("wc_pagos.js", "?1532591");
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

      protected void WB2R0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wc_pagos.aspx");
            }
            wb_table1_2_2R2( true) ;
         }
         else
         {
            wb_table1_2_2R2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2R2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2R2( )
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
            Form.Meta.addItem("Description", "Pagos de Factura de Pacientes", 0) ;
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
               STRUP2R0( ) ;
            }
         }
      }

      protected void WS2R2( )
      {
         START2R2( ) ;
         EVT2R2( ) ;
      }

      protected void EVT2R2( )
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
                                 STRUP2R0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'VALIDA'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E112R2 */
                                    E112R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGISTRAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E122R2 */
                                    E122R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ELIMINAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E132R2 */
                                    E132R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'FINALIZAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E142R2 */
                                    E142R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = dynavFormapagocodigo_Internalname ;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'ELIMINAR'") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2R0( ) ;
                              }
                              nGXsfl_38_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_38_idx ;
                              edtFacturaId_Internalname = sPrefix+"FACTURAID_"+sGXsfl_38_idx ;
                              edtFacturaPId_Internalname = sPrefix+"FACTURAPID_"+sGXsfl_38_idx ;
                              edtFormaPagoNombre_Internalname = sPrefix+"FORMAPAGONOMBRE_"+sGXsfl_38_idx ;
                              edtFacturaPMonto_Internalname = sPrefix+"FACTURAPMONTO_"+sGXsfl_38_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A185FacturaId = (int)(context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",")) ;
                              A260FacturaPId = (int)(context.localUtil.CToN( cgiGet( edtFacturaPId_Internalname), ".", ",")) ;
                              A66FormaPagoNombre = cgiGet( edtFormaPagoNombre_Internalname) ;
                              A261FacturaPMonto = context.localUtil.CToN( cgiGet( edtFacturaPMonto_Internalname), ".", ",") ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = dynavFormapagocodigo_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E152R2 */
                                          E152R2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = dynavFormapagocodigo_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ELIMINAR'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = dynavFormapagocodigo_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E132R2 */
                                          E132R2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP2R0( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = dynavFormapagocodigo_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE2R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2R2( ) ;
            }
         }
      }

      protected void PA2R2( )
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
            dynavFormapagocodigo.Name = "vFORMAPAGOCODIGO" ;
            dynavFormapagocodigo.WebTags = "" ;
            cmbavFacturapdetalle.Name = "vFACTURAPDETALLE" ;
            cmbavFacturapdetalle.WebTags = "" ;
            if ( ( cmbavFacturapdetalle.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10FacturaPDetalle)) )
            {
               AV10FacturaPDetalle = cmbavFacturapdetalle.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10FacturaPDetalle", AV10FacturaPDetalle);
            }
            GX_FocusControl = dynavFormapagocodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvFORMAPAGOCODIGO2R2( String AV5ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvFORMAPAGOCODIGO_data2R2( AV5ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXVvFORMAPAGOCODIGO_html2R2( String AV5ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLVvFORMAPAGOCODIGO_data2R2( AV5ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavFormapagocodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavFormapagocodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavFormapagocodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV7FormaPagoCodigo)) )
            {
               AV7FormaPagoCodigo = dynavFormapagocodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormaPagoCodigo", AV7FormaPagoCodigo);
            }
         }
      }

      protected void GXDLVvFORMAPAGOCODIGO_data2R2( String AV5ClinicaCodigo )
      {
         /* Using cursor H002R2 */
         pr_default.execute(0, new Object[] {AV5ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H002R2_A65FormaPagoCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002R2_A66FormaPagoNombre[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_38_idx ,
                                       String sGXsfl_38_idx ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_38_idx ;
         edtFacturaId_Internalname = sPrefix+"FACTURAID_"+sGXsfl_38_idx ;
         edtFacturaPId_Internalname = sPrefix+"FACTURAPID_"+sGXsfl_38_idx ;
         edtFormaPagoNombre_Internalname = sPrefix+"FORMAPAGONOMBRE_"+sGXsfl_38_idx ;
         edtFacturaPMonto_Internalname = sPrefix+"FACTURAPMONTO_"+sGXsfl_38_idx ;
         while ( nGXsfl_38_idx <= nRC_Grid1 )
         {
            sendrow_382( ) ;
            nGXsfl_38_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_38_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1)) ;
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_38_idx ;
            edtFacturaId_Internalname = sPrefix+"FACTURAID_"+sGXsfl_38_idx ;
            edtFacturaPId_Internalname = sPrefix+"FACTURAPID_"+sGXsfl_38_idx ;
            edtFormaPagoNombre_Internalname = sPrefix+"FORMAPAGONOMBRE_"+sGXsfl_38_idx ;
            edtFacturaPMonto_Internalname = sPrefix+"FACTURAPMONTO_"+sGXsfl_38_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String AV5ClinicaCodigo ,
                                        int AV6FacturaId ,
                                        String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF2R2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2R2( ) ;
         /* End function Refresh */
      }

      protected void RF2R2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 38 ;
         nGXsfl_38_idx = 1 ;
         sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_38_idx ;
         edtFacturaId_Internalname = sPrefix+"FACTURAID_"+sGXsfl_38_idx ;
         edtFacturaPId_Internalname = sPrefix+"FACTURAPID_"+sGXsfl_38_idx ;
         edtFormaPagoNombre_Internalname = sPrefix+"FORMAPAGONOMBRE_"+sGXsfl_38_idx ;
         edtFacturaPMonto_Internalname = sPrefix+"FACTURAPMONTO_"+sGXsfl_38_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_38_idx ;
            edtFacturaId_Internalname = sPrefix+"FACTURAID_"+sGXsfl_38_idx ;
            edtFacturaPId_Internalname = sPrefix+"FACTURAPID_"+sGXsfl_38_idx ;
            edtFormaPagoNombre_Internalname = sPrefix+"FORMAPAGONOMBRE_"+sGXsfl_38_idx ;
            edtFacturaPMonto_Internalname = sPrefix+"FACTURAPMONTO_"+sGXsfl_38_idx ;
            /* Using cursor H002R3 */
            pr_default.execute(1, new Object[] {AV5ClinicaCodigo, AV6FacturaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A65FormaPagoCodigo = H002R3_A65FormaPagoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A65FormaPagoCodigo", A65FormaPagoCodigo);
               A41ClinicaCodigo = H002R3_A41ClinicaCodigo[0] ;
               A261FacturaPMonto = H002R3_A261FacturaPMonto[0] ;
               A66FormaPagoNombre = H002R3_A66FormaPagoNombre[0] ;
               A260FacturaPId = H002R3_A260FacturaPId[0] ;
               A185FacturaId = H002R3_A185FacturaId[0] ;
               A66FormaPagoNombre = H002R3_A66FormaPagoNombre[0] ;
               /* Execute user event: E152R2 */
               E152R2 ();
               pr_default.readNext(1);
            }
            pr_default.close(1);
            wbEnd = 38 ;
            WB2R0( ) ;
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

      protected void STRUP2R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         GXVvFORMAPAGOCODIGO_html2R2( AV5ClinicaCodigo) ;
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
            dynavFormapagocodigo.Name = dynavFormapagocodigo_Internalname ;
            dynavFormapagocodigo.CurrentValue = cgiGet( dynavFormapagocodigo_Internalname) ;
            AV7FormaPagoCodigo = cgiGet( dynavFormapagocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormaPagoCodigo", AV7FormaPagoCodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavFacturapmonto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavFacturapmonto_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vFACTURAPMONTO");
               GX_FocusControl = edtavFacturapmonto_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8FacturaPMonto = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8FacturaPMonto", StringUtil.LTrim( StringUtil.Str( AV8FacturaPMonto, 17, 2)));
            }
            else
            {
               AV8FacturaPMonto = context.localUtil.CToN( cgiGet( edtavFacturapmonto_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8FacturaPMonto", StringUtil.LTrim( StringUtil.Str( AV8FacturaPMonto, 17, 2)));
            }
            cmbavFacturapdetalle.Name = cmbavFacturapdetalle_Internalname ;
            cmbavFacturapdetalle.CurrentValue = cgiGet( cmbavFacturapdetalle_Internalname) ;
            AV10FacturaPDetalle = cgiGet( cmbavFacturapdetalle_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10FacturaPDetalle", AV10FacturaPDetalle);
            AV9FacturaPDocto = cgiGet( edtavFacturapdocto_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9FacturaPDocto", AV9FacturaPDocto);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ".", ",")) ;
            wcpOAV5ClinicaCodigo = cgiGet( sPrefix+"wcpOAV5ClinicaCodigo") ;
            wcpOAV6FacturaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6FacturaId"), ".", ",")) ;
            wcpOAV12PacienteId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV12PacienteId"), ".", ",")) ;
            wcpOAV13ConsultaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV13ConsultaId"), ".", ",")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E112R2( )
      {
         /* 'Valida' Routine */
         cmbavFacturapdetalle.removeAllItems();
         if ( StringUtil.StrCmp(AV7FormaPagoCodigo, "CHE") == 0 )
         {
            /* Using cursor H002R4 */
            pr_default.execute(2, new Object[] {AV5ClinicaCodigo});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A127BancoDescripcion = H002R4_A127BancoDescripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127BancoDescripcion", A127BancoDescripcion);
               A126BancoCodigo = H002R4_A126BancoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126BancoCodigo", A126BancoCodigo);
               cmbavFacturapdetalle.addItem(A126BancoCodigo, A127BancoDescripcion, 0);
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         else
         {
            if ( StringUtil.StrCmp(AV7FormaPagoCodigo, "TAR") == 0 )
            {
               /* Using cursor H002R5 */
               pr_default.execute(3, new Object[] {AV5ClinicaCodigo});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A266EmisorNombre = H002R5_A266EmisorNombre[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A266EmisorNombre", A266EmisorNombre);
                  A265EmisorCodigo = H002R5_A265EmisorCodigo[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A265EmisorCodigo", A265EmisorCodigo);
                  cmbavFacturapdetalle.addItem(A265EmisorCodigo, A266EmisorNombre, 0);
                  pr_default.readNext(3);
               }
               pr_default.close(3);
            }
         }
      }

      protected void E122R2( )
      {
         /* 'Registrar' Routine */
         if ( ( AV8FacturaPMonto == Convert.ToDecimal( 0 )) )
         {
            GX_msglist.addItem("Debe ingresar el monto del medio de pago.");
         }
         else
         {
            new pvalidapagofactura(context ).execute( ref  AV5ClinicaCodigo, ref  AV6FacturaId, ref  AV11Flag) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
            if ( AV11Flag == 0 )
            {
               new pregistrafacturapago(context ).execute( ref  AV5ClinicaCodigo, ref  AV6FacturaId, ref  AV10FacturaPDetalle, ref  AV9FacturaPDocto, ref  AV8FacturaPMonto, ref  AV7FormaPagoCodigo) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10FacturaPDetalle", AV10FacturaPDetalle);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9FacturaPDocto", AV9FacturaPDocto);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8FacturaPMonto", StringUtil.LTrim( StringUtil.Str( AV8FacturaPMonto, 17, 2)));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormaPagoCodigo", AV7FormaPagoCodigo);
               cmbavFacturapdetalle.removeAllItems();
               AV9FacturaPDocto = "" ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9FacturaPDocto", AV9FacturaPDocto);
               AV8FacturaPMonto = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8FacturaPMonto", StringUtil.LTrim( StringUtil.Str( AV8FacturaPMonto, 17, 2)));
            }
         }
      }

      protected void E132R2( )
      {
         /* 'Eliminar' Routine */
         if ( A260FacturaPId == 0 )
         {
            GX_msglist.addItem("Seleccione una forma de pago para eliminar.");
         }
         else
         {
            new peliminafacturapago(context ).execute( ref  AV5ClinicaCodigo, ref  AV6FacturaId, ref  A260FacturaPId) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
         }
      }

      protected void E142R2( )
      {
         /* 'Finalizar' Routine */
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV13ConsultaId) + "," + UrlEncode("" +AV6FacturaId) + "," + UrlEncode("" +AV12PacienteId) ;
         context.wjLoc = formatLink("wp_factura.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      private void E152R2( )
      {
         /* Load Routine */
         sendrow_382( ) ;
      }

      protected void wb_table1_2_2R2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalle de Pago", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_11_2R2( true) ;
         }
         else
         {
            wb_table2_11_2R2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_2R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"DivS\" gxgridid=\"38\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Factura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Línea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Forma_Pago") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Monto") ;
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
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A260FacturaPId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A66FormaPagoNombre));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A261FacturaPMonto, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 38 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_38_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 3, 0)+","+"null"+");", "Finalizar", bttButton3_Jsonclick, 5, "Finalizar", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'FINALIZAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2R2e( true) ;
         }
         else
         {
            wb_table1_2_2R2e( false) ;
         }
      }

      protected void wb_table2_11_2R2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Medio Pago", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Monto", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Banco / Emisor", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Cheque / Autorización", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormaPagoCodigo", AV7FormaPagoCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'" + sPrefix + "',false,'" + sGXsfl_38_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavFormapagocodigo, dynavFormapagocodigo_Internalname, AV7FormaPagoCodigo, 1, dynavFormapagocodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(25);\"", "", true, "HLP_wc_Pagos.htm");
            dynavFormapagocodigo.CurrentValue = AV7FormaPagoCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavFormapagocodigo_Internalname, "Values", (String)(dynavFormapagocodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 3, 0)+","+"null"+");", ">|", bttButton1_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'VALIDA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8FacturaPMonto", StringUtil.LTrim( StringUtil.Str( AV8FacturaPMonto, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'" + sGXsfl_38_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavFacturapmonto_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8FacturaPMonto, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8FacturaPMonto, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV8FacturaPMonto, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavFacturapmonto_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10FacturaPDetalle", AV10FacturaPDetalle);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'" + sPrefix + "',false,'" + sGXsfl_38_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFacturapdetalle, cmbavFacturapdetalle_Internalname, AV10FacturaPDetalle, 1, cmbavFacturapdetalle_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 10, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(31);\"", "", true, "HLP_wc_Pagos.htm");
            cmbavFacturapdetalle.CurrentValue = AV10FacturaPDetalle ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavFacturapdetalle_Internalname, "Values", (String)(cmbavFacturapdetalle.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9FacturaPDocto", AV9FacturaPDocto);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'" + sPrefix + "',false,'" + sGXsfl_38_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavFacturapdocto_Internalname, StringUtil.RTrim( AV9FacturaPDocto), StringUtil.RTrim( context.localUtil.Format( AV9FacturaPDocto, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(33);\"", "", "", "", "", edtavFacturapdocto_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, true, "left", "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 3, 0)+","+"null"+");", "Registrar", bttButton2_Jsonclick, 5, "Registrar", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'REGISTRAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wc_Pagos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_2R2e( true) ;
         }
         else
         {
            wb_table2_11_2R2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5ClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
         AV6FacturaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
         AV12PacienteId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12PacienteId), 9, 0)));
         AV13ConsultaId = Convert.ToInt32(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ConsultaId), 9, 0)));
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
         PA2R2( ) ;
         WS2R2( ) ;
         WE2R2( ) ;
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
         sCtrlAV5ClinicaCodigo = (String)((String)getParm(obj,0)) ;
         sCtrlAV6FacturaId = (String)((String)getParm(obj,1)) ;
         sCtrlAV12PacienteId = (String)((String)getParm(obj,2)) ;
         sCtrlAV13ConsultaId = (String)((String)getParm(obj,3)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA2R2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "wc_pagos");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA2R2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV5ClinicaCodigo = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
            AV6FacturaId = Convert.ToInt32(getParm(obj,3)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
            AV12PacienteId = Convert.ToInt32(getParm(obj,4)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12PacienteId), 9, 0)));
            AV13ConsultaId = Convert.ToInt32(getParm(obj,5)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ConsultaId), 9, 0)));
         }
         wcpOAV5ClinicaCodigo = cgiGet( sPrefix+"wcpOAV5ClinicaCodigo") ;
         wcpOAV6FacturaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6FacturaId"), ".", ",")) ;
         wcpOAV12PacienteId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV12PacienteId"), ".", ",")) ;
         wcpOAV13ConsultaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV13ConsultaId"), ".", ",")) ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV5ClinicaCodigo, wcpOAV5ClinicaCodigo) != 0 ) || ( AV6FacturaId != wcpOAV6FacturaId ) || ( AV12PacienteId != wcpOAV12PacienteId ) || ( AV13ConsultaId != wcpOAV13ConsultaId ) ) )
         {
            setjustcreated();
         }
         wcpOAV5ClinicaCodigo = AV5ClinicaCodigo ;
         wcpOAV6FacturaId = AV6FacturaId ;
         wcpOAV12PacienteId = AV12PacienteId ;
         wcpOAV13ConsultaId = AV13ConsultaId ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV5ClinicaCodigo = cgiGet( sPrefix+"AV5ClinicaCodigo_CTRL") ;
         if ( StringUtil.Len( sCtrlAV5ClinicaCodigo) > 0 )
         {
            AV5ClinicaCodigo = cgiGet( sCtrlAV5ClinicaCodigo) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ClinicaCodigo", AV5ClinicaCodigo);
         }
         else
         {
            AV5ClinicaCodigo = cgiGet( sPrefix+"AV5ClinicaCodigo_PARM") ;
         }
         sCtrlAV6FacturaId = cgiGet( sPrefix+"AV6FacturaId_CTRL") ;
         if ( StringUtil.Len( sCtrlAV6FacturaId) > 0 )
         {
            AV6FacturaId = (int)(context.localUtil.CToN( cgiGet( sCtrlAV6FacturaId), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6FacturaId), 9, 0)));
         }
         else
         {
            AV6FacturaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"AV6FacturaId_PARM"), ".", ",")) ;
         }
         sCtrlAV12PacienteId = cgiGet( sPrefix+"AV12PacienteId_CTRL") ;
         if ( StringUtil.Len( sCtrlAV12PacienteId) > 0 )
         {
            AV12PacienteId = (int)(context.localUtil.CToN( cgiGet( sCtrlAV12PacienteId), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12PacienteId), 9, 0)));
         }
         else
         {
            AV12PacienteId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"AV12PacienteId_PARM"), ".", ",")) ;
         }
         sCtrlAV13ConsultaId = cgiGet( sPrefix+"AV13ConsultaId_CTRL") ;
         if ( StringUtil.Len( sCtrlAV13ConsultaId) > 0 )
         {
            AV13ConsultaId = (int)(context.localUtil.CToN( cgiGet( sCtrlAV13ConsultaId), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ConsultaId), 9, 0)));
         }
         else
         {
            AV13ConsultaId = (int)(context.localUtil.CToN( cgiGet( sPrefix+"AV13ConsultaId_PARM"), ".", ",")) ;
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
         PA2R2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS2R2( ) ;
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
         WS2R2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV5ClinicaCodigo_PARM", StringUtil.RTrim( AV5ClinicaCodigo));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV5ClinicaCodigo)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV5ClinicaCodigo_CTRL", StringUtil.RTrim( sCtrlAV5ClinicaCodigo));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV6FacturaId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6FacturaId), 9, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV6FacturaId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV6FacturaId_CTRL", StringUtil.RTrim( sCtrlAV6FacturaId));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV12PacienteId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12PacienteId), 9, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV12PacienteId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV12PacienteId_CTRL", StringUtil.RTrim( sCtrlAV12PacienteId));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV13ConsultaId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13ConsultaId), 9, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV13ConsultaId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV13ConsultaId_CTRL", StringUtil.RTrim( sCtrlAV13ConsultaId));
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
         WE2R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1532665");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("wc_pagos.js", "?1532665");
         /* End function include_jscripts */
      }

      protected void sendrow_382( )
      {
         WB2R0( ) ;
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
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
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
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( ((int)(nGXsfl_38_idx) % (2)) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even" ;
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
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
            context.WriteHtmlText( " gxrow=\""+sGXsfl_38_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)38,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)38,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaPId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A260FacturaPId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A260FacturaPId), "ZZZZZZZZ9"),(String)"",sPrefix+"E\\'ELIMINAR\\'."+sGXsfl_38_idx,(String)"",(String)"",(String)"",(String)edtFacturaPId_Jsonclick,(short)5,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)38,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFormaPagoNombre_Internalname,StringUtil.RTrim( A66FormaPagoNombre),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFormaPagoNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)38,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaPMonto_Internalname,StringUtil.LTrim( StringUtil.NToC( A261FacturaPMonto, 17, 2, ".", "")),context.localUtil.Format( A261FacturaPMonto, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaPMonto_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)38,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_38_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_38_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1)) ;
         sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_38_idx ;
         edtFacturaId_Internalname = sPrefix+"FACTURAID_"+sGXsfl_38_idx ;
         edtFacturaPId_Internalname = sPrefix+"FACTURAPID_"+sGXsfl_38_idx ;
         edtFormaPagoNombre_Internalname = sPrefix+"FORMAPAGONOMBRE_"+sGXsfl_38_idx ;
         edtFacturaPMonto_Internalname = sPrefix+"FACTURAPMONTO_"+sGXsfl_38_idx ;
         /* End function sendrow_382 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = sPrefix+"TEXTBLOCK1" ;
         lblTextblock6_Internalname = sPrefix+"TEXTBLOCK6" ;
         lblTextblock5_Internalname = sPrefix+"TEXTBLOCK5" ;
         lblTextblock4_Internalname = sPrefix+"TEXTBLOCK4" ;
         lblTextblock3_Internalname = sPrefix+"TEXTBLOCK3" ;
         dynavFormapagocodigo_Internalname = sPrefix+"vFORMAPAGOCODIGO" ;
         bttButton1_Internalname = sPrefix+"BUTTON1" ;
         edtavFacturapmonto_Internalname = sPrefix+"vFACTURAPMONTO" ;
         cmbavFacturapdetalle_Internalname = sPrefix+"vFACTURAPDETALLE" ;
         edtavFacturapdocto_Internalname = sPrefix+"vFACTURAPDOCTO" ;
         bttButton2_Internalname = sPrefix+"BUTTON2" ;
         tblTable2_Internalname = sPrefix+"TABLE2" ;
         bttButton3_Internalname = sPrefix+"BUTTON3" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid1_Internalname = sPrefix+"GRID1" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtFacturaPMonto_Jsonclick = "" ;
         edtFormaPagoNombre_Jsonclick = "" ;
         edtFacturaPId_Jsonclick = "" ;
         edtFacturaId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavFacturapdocto_Jsonclick = "" ;
         cmbavFacturapdetalle_Jsonclick = "" ;
         edtavFacturapmonto_Jsonclick = "" ;
         dynavFormapagocodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
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
         wcpOAV5ClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV10FacturaPDetalle = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtFacturaId_Internalname = "" ;
         edtFacturaPId_Internalname = "" ;
         edtFormaPagoNombre_Internalname = "" ;
         edtFacturaPMonto_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A66FormaPagoNombre = "" ;
         GXDecQS = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         AV7FormaPagoCodigo = "" ;
         scmdbuf = "" ;
         H002R2_A65FormaPagoCodigo = new String[] {""} ;
         H002R2_A66FormaPagoNombre = new String[] {""} ;
         H002R2_A41ClinicaCodigo = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         H002R3_A65FormaPagoCodigo = new String[] {""} ;
         H002R3_A41ClinicaCodigo = new String[] {""} ;
         H002R3_A261FacturaPMonto = new decimal[1] ;
         H002R3_A66FormaPagoNombre = new String[] {""} ;
         H002R3_A260FacturaPId = new int[1] ;
         H002R3_A185FacturaId = new int[1] ;
         A65FormaPagoCodigo = "" ;
         AV9FacturaPDocto = "" ;
         H002R4_A41ClinicaCodigo = new String[] {""} ;
         H002R4_A127BancoDescripcion = new String[] {""} ;
         H002R4_A126BancoCodigo = new String[] {""} ;
         A127BancoDescripcion = "" ;
         A126BancoCodigo = "" ;
         H002R5_A41ClinicaCodigo = new String[] {""} ;
         H002R5_A266EmisorNombre = new String[] {""} ;
         H002R5_A265EmisorCodigo = new String[] {""} ;
         A266EmisorNombre = "" ;
         A265EmisorCodigo = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char7 = "" ;
         TempTags = "" ;
         bttButton3_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV5ClinicaCodigo = "" ;
         sCtrlAV6FacturaId = "" ;
         sCtrlAV12PacienteId = "" ;
         sCtrlAV13ConsultaId = "" ;
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wc_pagos__default(),
            new Object[][] {
                new Object[] {
               H002R2_A65FormaPagoCodigo, H002R2_A66FormaPagoNombre, H002R2_A41ClinicaCodigo
               }
               , new Object[] {
               H002R3_A65FormaPagoCodigo, H002R3_A41ClinicaCodigo, H002R3_A261FacturaPMonto, H002R3_A66FormaPagoNombre, H002R3_A260FacturaPId, H002R3_A185FacturaId
               }
               , new Object[] {
               H002R4_A41ClinicaCodigo, H002R4_A127BancoDescripcion, H002R4_A126BancoCodigo
               }
               , new Object[] {
               H002R5_A41ClinicaCodigo, H002R5_A266EmisorNombre, H002R5_A265EmisorCodigo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_Grid1 ;
      private short nGXsfl_38_idx=1 ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short AV11Flag ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV6FacturaId ;
      private int AV12PacienteId ;
      private int AV13ConsultaId ;
      private int wcpOAV6FacturaId ;
      private int wcpOAV12PacienteId ;
      private int wcpOAV13ConsultaId ;
      private int A185FacturaId ;
      private int A260FacturaPId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A261FacturaPMonto ;
      private decimal AV8FacturaPMonto ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_38_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String dynavFormapagocodigo_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtFacturaId_Internalname ;
      private String edtFacturaPId_Internalname ;
      private String edtFormaPagoNombre_Internalname ;
      private String edtFacturaPMonto_Internalname ;
      private String GXDecQS ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavFacturapmonto_Internalname ;
      private String cmbavFacturapdetalle_Internalname ;
      private String edtavFacturapdocto_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char7 ;
      private String TempTags ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String dynavFormapagocodigo_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavFacturapmonto_Jsonclick ;
      private String cmbavFacturapdetalle_Jsonclick ;
      private String edtavFacturapdocto_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String sCtrlAV5ClinicaCodigo ;
      private String sCtrlAV6FacturaId ;
      private String sCtrlAV12PacienteId ;
      private String sCtrlAV13ConsultaId ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtFacturaId_Jsonclick ;
      private String edtFacturaPId_Jsonclick ;
      private String edtFormaPagoNombre_Jsonclick ;
      private String edtFacturaPMonto_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private String AV5ClinicaCodigo ;
      private String wcpOAV5ClinicaCodigo ;
      private String AV10FacturaPDetalle ;
      private String A41ClinicaCodigo ;
      private String A66FormaPagoNombre ;
      private String AV7FormaPagoCodigo ;
      private String A65FormaPagoCodigo ;
      private String AV9FacturaPDocto ;
      private String A127BancoDescripcion ;
      private String A126BancoCodigo ;
      private String A266EmisorNombre ;
      private String A265EmisorCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_FacturaId ;
      private int aP2_PacienteId ;
      private int aP3_ConsultaId ;
      private GXCombobox dynavFormapagocodigo ;
      private GXCombobox cmbavFacturapdetalle ;
      private IDataStoreProvider pr_default ;
      private String[] H002R2_A65FormaPagoCodigo ;
      private String[] H002R2_A66FormaPagoNombre ;
      private String[] H002R2_A41ClinicaCodigo ;
      private String[] H002R3_A65FormaPagoCodigo ;
      private String[] H002R3_A41ClinicaCodigo ;
      private decimal[] H002R3_A261FacturaPMonto ;
      private String[] H002R3_A66FormaPagoNombre ;
      private int[] H002R3_A260FacturaPId ;
      private int[] H002R3_A185FacturaId ;
      private String[] H002R4_A41ClinicaCodigo ;
      private String[] H002R4_A127BancoDescripcion ;
      private String[] H002R4_A126BancoCodigo ;
      private String[] H002R5_A41ClinicaCodigo ;
      private String[] H002R5_A266EmisorNombre ;
      private String[] H002R5_A265EmisorCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class wc_pagos__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002R2 ;
          prmH002R2 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH002R3 ;
          prmH002R3 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002R4 ;
          prmH002R4 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH002R5 ;
          prmH002R5 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002R2", "SELECT [FormaPagoCodigo], [FormaPagoNombre], [ClinicaCodigo] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV5ClinicaCodigo ORDER BY [FormaPagoNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002R2,0,0,true,false )
             ,new CursorDef("H002R3", "SELECT T1.[FormaPagoCodigo], T1.[ClinicaCodigo], T1.[FacturaPMonto], T2.[FormaPagoNombre], T1.[FacturaPId], T1.[FacturaId] FROM ([FacturaPago] T1 WITH (NOLOCK) INNER JOIN [FormaPago] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[FormaPagoCodigo] = T1.[FormaPagoCodigo]) WHERE T1.[ClinicaCodigo] = @AV5ClinicaCodigo and T1.[FacturaId] = @AV6FacturaId ORDER BY T1.[ClinicaCodigo], T1.[FacturaId], T1.[FacturaPId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002R3,11,0,true,false )
             ,new CursorDef("H002R4", "SELECT [ClinicaCodigo], [BancoDescripcion], [BancoCodigo] FROM [Banco] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV5ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002R4,100,0,false,false )
             ,new CursorDef("H002R5", "SELECT [ClinicaCodigo], [EmisorNombre], [EmisorCodigo] FROM [EmisorTarjeta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV5ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002R5,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 3 :
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
