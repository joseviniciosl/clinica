/*
               File: wc_Cargos
        Description: Cargos de Consultas a Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:27.63
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
   public class wc_cargos : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wc_cargos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wc_cargos( IGxContext context )
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
         dynavArticulocodigo = new GXCombobox();
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
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A41ClinicaCodigo,(int)A91ConsultaId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vARTICULOCODIGO") == 0 )
               {
                  A41ClinicaCodigo = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  GXDLVvARTICULOCODIGO1M2( A41ClinicaCodigo) ;
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
                  nGXsfl_34_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_34_idx = GetNextPar( ) ;
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid1_newrow( nRC_Grid1, nGXsfl_34_idx, sGXsfl_34_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  /* GeneXus formulas. */
                  context.Gx_err = 0 ;
                  dynavArticulocodigo.Name = "vARTICULOCODIGO" ;
                  dynavArticulocodigo.WebTags = "" ;
                  A41ClinicaCodigo = GetNextPar( ) ;
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid1_refresh( A41ClinicaCodigo, A91ConsultaId, sPrefix) ;
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
            PA1M2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavCargoprecio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavCargoprecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCargoprecio_Enabled), 5, 0)));
               GXVvARTICULOCODIGO_html1M2( A41ClinicaCodigo) ;
               WS1M2( ) ;
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
            context.WriteHtmlText( "Cargos de Consultas a Pacientes") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wc_cargos.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm1M2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA41ClinicaCodigo", StringUtil.RTrim( wcpOA41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA91ConsultaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA91ConsultaId), 9, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("wc_cargos.js", "?1532768");
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

      protected void WB1M0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wc_cargos.aspx");
            }
            wb_table1_2_1M2( true) ;
         }
         else
         {
            wb_table1_2_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1M2( )
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
            Form.Meta.addItem("Description", "Cargos de Consultas a Pacientes", 0) ;
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
               STRUP1M0( ) ;
            }
         }
      }

      protected void WS1M2( )
      {
         START1M2( ) ;
         EVT1M2( ) ;
      }

      protected void EVT1M2( )
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
                                 STRUP1M0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'VALIDAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1M0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E111M2 */
                                    E111M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGISTRAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1M0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E121M2 */
                                    E121M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ELIMINAR'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1M0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E131M2 */
                                    E131M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1M0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = dynavArticulocodigo_Internalname ;
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
                                 STRUP1M0( ) ;
                              }
                              nGXsfl_34_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_34_idx ;
                              edtConsultaId_Internalname = sPrefix+"CONSULTAID_"+sGXsfl_34_idx ;
                              edtCargoId_Internalname = sPrefix+"CARGOID_"+sGXsfl_34_idx ;
                              edtArticuloCodigo_Internalname = sPrefix+"ARTICULOCODIGO_"+sGXsfl_34_idx ;
                              edtArticuloDescripcion_Internalname = sPrefix+"ARTICULODESCRIPCION_"+sGXsfl_34_idx ;
                              edtCargoPrecio_Internalname = sPrefix+"CARGOPRECIO_"+sGXsfl_34_idx ;
                              edtCargoCantidad_Internalname = sPrefix+"CARGOCANTIDAD_"+sGXsfl_34_idx ;
                              edtCargoTotal_Internalname = sPrefix+"CARGOTOTAL_"+sGXsfl_34_idx ;
                              if ( StringUtil.Len( sPrefix) == 0 )
                              {
                                 A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              }
                              if ( StringUtil.Len( sPrefix) == 0 )
                              {
                                 A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",")) ;
                              }
                              A162CargoId = (int)(context.localUtil.CToN( cgiGet( edtCargoId_Internalname), ".", ",")) ;
                              A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
                              A31ArticuloDescripcion = cgiGet( edtArticuloDescripcion_Internalname) ;
                              A163CargoPrecio = context.localUtil.CToN( cgiGet( edtCargoPrecio_Internalname), ".", ",") ;
                              A164CargoCantidad = context.localUtil.CToN( cgiGet( edtCargoCantidad_Internalname), ".", ",") ;
                              A165CargoTotal = context.localUtil.CToN( cgiGet( edtCargoTotal_Internalname), ".", ",") ;
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
                                          GX_FocusControl = dynavArticulocodigo_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E141M2 */
                                          E141M2 ();
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
                                          GX_FocusControl = dynavArticulocodigo_Internalname ;
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
                                          GX_FocusControl = dynavArticulocodigo_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E131M2 */
                                          E131M2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP1M0( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = dynavArticulocodigo_Internalname ;
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

      protected void WE1M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1M2( ) ;
            }
         }
      }

      protected void PA1M2( )
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
            dynavArticulocodigo.Name = "vARTICULOCODIGO" ;
            dynavArticulocodigo.WebTags = "" ;
            GX_FocusControl = dynavArticulocodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvARTICULOCODIGO1M2( String A41ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvARTICULOCODIGO_data1M2( A41ClinicaCodigo) ;
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

      protected void GXVvARTICULOCODIGO_html1M2( String A41ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLVvARTICULOCODIGO_data1M2( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavArticulocodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavArticulocodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavArticulocodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV5ArticuloCodigo)) )
            {
               AV5ArticuloCodigo = dynavArticulocodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ArticuloCodigo", AV5ArticuloCodigo);
            }
         }
      }

      protected void GXDLVvARTICULOCODIGO_data1M2( String A41ClinicaCodigo )
      {
         /* Using cursor H001M2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001M2_A30ArticuloCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001M2_A31ArticuloDescripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_34_idx ,
                                       String sGXsfl_34_idx ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_34_idx ;
         edtConsultaId_Internalname = sPrefix+"CONSULTAID_"+sGXsfl_34_idx ;
         edtCargoId_Internalname = sPrefix+"CARGOID_"+sGXsfl_34_idx ;
         edtArticuloCodigo_Internalname = sPrefix+"ARTICULOCODIGO_"+sGXsfl_34_idx ;
         edtArticuloDescripcion_Internalname = sPrefix+"ARTICULODESCRIPCION_"+sGXsfl_34_idx ;
         edtCargoPrecio_Internalname = sPrefix+"CARGOPRECIO_"+sGXsfl_34_idx ;
         edtCargoCantidad_Internalname = sPrefix+"CARGOCANTIDAD_"+sGXsfl_34_idx ;
         edtCargoTotal_Internalname = sPrefix+"CARGOTOTAL_"+sGXsfl_34_idx ;
         while ( nGXsfl_34_idx <= nRC_Grid1 )
         {
            sendrow_342( ) ;
            nGXsfl_34_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_34_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_34_idx+1)) ;
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_34_idx ;
            edtConsultaId_Internalname = sPrefix+"CONSULTAID_"+sGXsfl_34_idx ;
            edtCargoId_Internalname = sPrefix+"CARGOID_"+sGXsfl_34_idx ;
            edtArticuloCodigo_Internalname = sPrefix+"ARTICULOCODIGO_"+sGXsfl_34_idx ;
            edtArticuloDescripcion_Internalname = sPrefix+"ARTICULODESCRIPCION_"+sGXsfl_34_idx ;
            edtCargoPrecio_Internalname = sPrefix+"CARGOPRECIO_"+sGXsfl_34_idx ;
            edtCargoCantidad_Internalname = sPrefix+"CARGOCANTIDAD_"+sGXsfl_34_idx ;
            edtCargoTotal_Internalname = sPrefix+"CARGOTOTAL_"+sGXsfl_34_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String A41ClinicaCodigo ,
                                        int A91ConsultaId ,
                                        String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF1M2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1M2( ) ;
         /* End function Refresh */
      }

      protected void RF1M2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 34 ;
         nGXsfl_34_idx = 1 ;
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_34_idx ;
         edtConsultaId_Internalname = sPrefix+"CONSULTAID_"+sGXsfl_34_idx ;
         edtCargoId_Internalname = sPrefix+"CARGOID_"+sGXsfl_34_idx ;
         edtArticuloCodigo_Internalname = sPrefix+"ARTICULOCODIGO_"+sGXsfl_34_idx ;
         edtArticuloDescripcion_Internalname = sPrefix+"ARTICULODESCRIPCION_"+sGXsfl_34_idx ;
         edtCargoPrecio_Internalname = sPrefix+"CARGOPRECIO_"+sGXsfl_34_idx ;
         edtCargoCantidad_Internalname = sPrefix+"CARGOCANTIDAD_"+sGXsfl_34_idx ;
         edtCargoTotal_Internalname = sPrefix+"CARGOTOTAL_"+sGXsfl_34_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_34_idx ;
            edtConsultaId_Internalname = sPrefix+"CONSULTAID_"+sGXsfl_34_idx ;
            edtCargoId_Internalname = sPrefix+"CARGOID_"+sGXsfl_34_idx ;
            edtArticuloCodigo_Internalname = sPrefix+"ARTICULOCODIGO_"+sGXsfl_34_idx ;
            edtArticuloDescripcion_Internalname = sPrefix+"ARTICULODESCRIPCION_"+sGXsfl_34_idx ;
            edtCargoPrecio_Internalname = sPrefix+"CARGOPRECIO_"+sGXsfl_34_idx ;
            edtCargoCantidad_Internalname = sPrefix+"CARGOCANTIDAD_"+sGXsfl_34_idx ;
            edtCargoTotal_Internalname = sPrefix+"CARGOTOTAL_"+sGXsfl_34_idx ;
            /* Using cursor H001M3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A31ArticuloDescripcion = H001M3_A31ArticuloDescripcion[0] ;
               A30ArticuloCodigo = H001M3_A30ArticuloCodigo[0] ;
               A162CargoId = H001M3_A162CargoId[0] ;
               A164CargoCantidad = H001M3_A164CargoCantidad[0] ;
               A163CargoPrecio = H001M3_A163CargoPrecio[0] ;
               A31ArticuloDescripcion = H001M3_A31ArticuloDescripcion[0] ;
               A165CargoTotal = (decimal)(A163CargoPrecio*A164CargoCantidad) ;
               /* Execute user event: E141M2 */
               E141M2 ();
               pr_default.readNext(1);
            }
            pr_default.close(1);
            wbEnd = 34 ;
            WB1M0( ) ;
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

      protected void STRUP1M0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavCargoprecio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavCargoprecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCargoprecio_Enabled), 5, 0)));
         GXVvARTICULOCODIGO_html1M2( A41ClinicaCodigo) ;
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
            dynavArticulocodigo.Name = dynavArticulocodigo_Internalname ;
            dynavArticulocodigo.CurrentValue = cgiGet( dynavArticulocodigo_Internalname) ;
            AV5ArticuloCodigo = cgiGet( dynavArticulocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ArticuloCodigo", AV5ArticuloCodigo);
            AV7CargoPrecio = context.localUtil.CToN( cgiGet( edtavCargoprecio_Internalname), ".", ",") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7CargoPrecio", StringUtil.LTrim( StringUtil.Str( AV7CargoPrecio, 17, 2)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCargocantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCargocantidad_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARGOCANTIDAD");
               GX_FocusControl = edtavCargocantidad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6CargoCantidad = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6CargoCantidad", StringUtil.LTrim( StringUtil.Str( AV6CargoCantidad, 17, 2)));
            }
            else
            {
               AV6CargoCantidad = context.localUtil.CToN( cgiGet( edtavCargocantidad_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6CargoCantidad", StringUtil.LTrim( StringUtil.Str( AV6CargoCantidad, 17, 2)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ".", ",")) ;
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

      protected void E111M2( )
      {
         /* 'Validar' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV5ArticuloCodigo)) )
         {
            GX_msglist.addItem("Debe seleccionar un código de servicio / producto válido.");
         }
         else
         {
            GXt_decimal6 = AV7CargoPrecio ;
            new oobtienearticulo(context ).execute(  A41ClinicaCodigo,  AV5ArticuloCodigo, out  GXt_decimal6) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ArticuloCodigo", AV5ArticuloCodigo);
            AV7CargoPrecio = GXt_decimal6 ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7CargoPrecio", StringUtil.LTrim( StringUtil.Str( AV7CargoPrecio, 17, 2)));
            AV6CargoCantidad = (decimal)(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6CargoCantidad", StringUtil.LTrim( StringUtil.Str( AV6CargoCantidad, 17, 2)));
         }
      }

      protected void E121M2( )
      {
         /* 'Registrar' Routine */
         GXt_int7 = 1 ;
         new pregistracargos(context ).execute( ref  A41ClinicaCodigo, ref  A91ConsultaId, ref  AV5ArticuloCodigo, ref  AV7CargoPrecio, ref  AV6CargoCantidad, ref  GXt_int7) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ArticuloCodigo", AV5ArticuloCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7CargoPrecio", StringUtil.LTrim( StringUtil.Str( AV7CargoPrecio, 17, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6CargoCantidad", StringUtil.LTrim( StringUtil.Str( AV6CargoCantidad, 17, 2)));
      }

      protected void E131M2( )
      {
         /* 'Eliminar' Routine */
         new peliminacargos(context ).execute( ref  A41ClinicaCodigo, ref  A91ConsultaId, ref  A162CargoId) ;
      }

      private void E141M2( )
      {
         /* Load Routine */
         sendrow_342( ) ;
      }

      protected void wb_table1_2_1M2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Registro de Cargos a Consultas", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Cargos.htm");
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:66px\">") ;
            wb_table2_11_1M2( true) ;
         }
         else
         {
            wb_table2_11_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:16px\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"DivS\" gxgridid=\"34\">") ;
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
               context.SendWebValue( "Consulta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Artículo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Artículo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Precio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Total") ;
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
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A162CargoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A31ArticuloDescripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A163CargoPrecio, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A164CargoCantidad, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A165CargoTotal, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 34 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_34_idx-1) ;
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
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1M2e( true) ;
         }
         else
         {
            wb_table1_2_1M2e( false) ;
         }
      }

      protected void wb_table2_11_1M2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock17_Internalname, "Servicio / Producto", "", "", lblTextblock17_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, "Precio Unitario", "", "", lblTextblock16_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, "Cantidad", "", "", lblTextblock15_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5ArticuloCodigo", AV5ArticuloCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'" + sGXsfl_34_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavArticulocodigo, dynavArticulocodigo_Internalname, AV5ArticuloCodigo, 1, dynavArticulocodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(23);\"", "", true, "HLP_wc_Cargos.htm");
            dynavArticulocodigo.CurrentValue = AV5ArticuloCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavArticulocodigo_Internalname, "Values", (String)(dynavArticulocodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(34), 3, 0)+","+"null"+");", ">|", bttButton1_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'VALIDAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7CargoPrecio", StringUtil.LTrim( StringUtil.Str( AV7CargoPrecio, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCargoprecio_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7CargoPrecio, 17, 2, ".", "")), ((edtavCargoprecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7CargoPrecio, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV7CargoPrecio, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtavCargoprecio_Jsonclick, 0, ClassString, StyleString, "", 1, edtavCargoprecio_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6CargoCantidad", StringUtil.LTrim( StringUtil.Str( AV6CargoCantidad, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'" + sGXsfl_34_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCargocantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6CargoCantidad, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6CargoCantidad, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV6CargoCantidad, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCargocantidad_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(34), 3, 0)+","+"null"+");", "Registrar", bttButton2_Jsonclick, 5, "Registrar", "", StyleString, ClassString, 1, 1, "standard", sPrefix+"E\\'REGISTRAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wc_Cargos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1M2e( true) ;
         }
         else
         {
            wb_table2_11_1M2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A41ClinicaCodigo = (String)getParm(obj,0) ;
         A91ConsultaId = Convert.ToInt32(getParm(obj,1)) ;
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
         PA1M2( ) ;
         WS1M2( ) ;
         WE1M2( ) ;
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
         PA1M2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "wc_cargos");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA1M2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A41ClinicaCodigo = (String)getParm(obj,2) ;
            A91ConsultaId = Convert.ToInt32(getParm(obj,3)) ;
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
         }
         else
         {
            A41ClinicaCodigo = cgiGet( sPrefix+"A41ClinicaCodigo_PARM") ;
         }
         sCtrlA91ConsultaId = cgiGet( sPrefix+"A91ConsultaId_CTRL") ;
         if ( StringUtil.Len( sCtrlA91ConsultaId) > 0 )
         {
            A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( sCtrlA91ConsultaId), ".", ",")) ;
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
         PA1M2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS1M2( ) ;
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
         WS1M2( ) ;
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
         WE1M2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1532823");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("wc_cargos.js", "?1532823");
         /* End function include_jscripts */
      }

      protected void sendrow_342( )
      {
         WB1M0( ) ;
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
            if ( ((int)(nGXsfl_34_idx) % (2)) == 0 )
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
            context.WriteHtmlText( " gxrow=\""+sGXsfl_34_idx+"\">") ;
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
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A162CargoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A162CargoId), "ZZZZZZZZ9"),(String)"",sPrefix+"E\\'ELIMINAR\\'."+sGXsfl_34_idx,(String)"",(String)"",(String)"",(String)edtCargoId_Jsonclick,(short)5,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloDescripcion_Internalname,StringUtil.RTrim( A31ArticuloDescripcion),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargoPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( A163CargoPrecio, 17, 2, ".", "")),context.localUtil.Format( A163CargoPrecio, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCargoPrecio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargoCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A164CargoCantidad, 17, 2, ".", "")),context.localUtil.Format( A164CargoCantidad, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCargoCantidad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A165CargoTotal, 17, 2, ".", "")),context.localUtil.Format( A165CargoTotal, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCargoTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)34,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_34_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_34_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_34_idx+1)) ;
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = sPrefix+"CLINICACODIGO_"+sGXsfl_34_idx ;
         edtConsultaId_Internalname = sPrefix+"CONSULTAID_"+sGXsfl_34_idx ;
         edtCargoId_Internalname = sPrefix+"CARGOID_"+sGXsfl_34_idx ;
         edtArticuloCodigo_Internalname = sPrefix+"ARTICULOCODIGO_"+sGXsfl_34_idx ;
         edtArticuloDescripcion_Internalname = sPrefix+"ARTICULODESCRIPCION_"+sGXsfl_34_idx ;
         edtCargoPrecio_Internalname = sPrefix+"CARGOPRECIO_"+sGXsfl_34_idx ;
         edtCargoCantidad_Internalname = sPrefix+"CARGOCANTIDAD_"+sGXsfl_34_idx ;
         edtCargoTotal_Internalname = sPrefix+"CARGOTOTAL_"+sGXsfl_34_idx ;
         /* End function sendrow_342 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = sPrefix+"TEXTBLOCK1" ;
         lblTextblock17_Internalname = sPrefix+"TEXTBLOCK17" ;
         lblTextblock16_Internalname = sPrefix+"TEXTBLOCK16" ;
         lblTextblock15_Internalname = sPrefix+"TEXTBLOCK15" ;
         dynavArticulocodigo_Internalname = sPrefix+"vARTICULOCODIGO" ;
         bttButton1_Internalname = sPrefix+"BUTTON1" ;
         edtavCargoprecio_Internalname = sPrefix+"vCARGOPRECIO" ;
         edtavCargocantidad_Internalname = sPrefix+"vCARGOCANTIDAD" ;
         bttButton2_Internalname = sPrefix+"BUTTON2" ;
         tblTable2_Internalname = sPrefix+"TABLE2" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid1_Internalname = sPrefix+"GRID1" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtCargoTotal_Jsonclick = "" ;
         edtCargoCantidad_Jsonclick = "" ;
         edtCargoPrecio_Jsonclick = "" ;
         edtArticuloDescripcion_Jsonclick = "" ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtCargoId_Jsonclick = "" ;
         edtConsultaId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCargocantidad_Jsonclick = "" ;
         edtavCargoprecio_Jsonclick = "" ;
         edtavCargoprecio_Enabled = 0 ;
         dynavArticulocodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      public void Valid_Clinicacodigo( String GX_Parm1 ,
                                       GXCombobox dynGX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynavArticulocodigo = dynGX_Parm2 ;
         AV5ArticuloCodigo = dynavArticulocodigo.CurrentValue ;
         GXVvARTICULOCODIGO_html1M2( A41ClinicaCodigo) ;
         dynload_actions( ) ;
         isValidOutput.Add((Object)(dynavArticulocodigo));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
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
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtConsultaId_Internalname = "" ;
         edtCargoId_Internalname = "" ;
         edtArticuloCodigo_Internalname = "" ;
         edtArticuloDescripcion_Internalname = "" ;
         edtCargoPrecio_Internalname = "" ;
         edtCargoCantidad_Internalname = "" ;
         edtCargoTotal_Internalname = "" ;
         A30ArticuloCodigo = "" ;
         A31ArticuloDescripcion = "" ;
         GXDecQS = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         AV5ArticuloCodigo = "" ;
         scmdbuf = "" ;
         H001M2_A41ClinicaCodigo = new String[] {""} ;
         H001M2_A30ArticuloCodigo = new String[] {""} ;
         H001M2_A31ArticuloDescripcion = new String[] {""} ;
         H001M2_A34ArticuloEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         H001M3_A41ClinicaCodigo = new String[] {""} ;
         H001M3_A91ConsultaId = new int[1] ;
         H001M3_A31ArticuloDescripcion = new String[] {""} ;
         H001M3_A30ArticuloCodigo = new String[] {""} ;
         H001M3_A162CargoId = new int[1] ;
         H001M3_A164CargoCantidad = new decimal[1] ;
         H001M3_A163CargoPrecio = new decimal[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char8 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char9 = "" ;
         lblTextblock17_Jsonclick = "" ;
         lblTextblock16_Jsonclick = "" ;
         lblTextblock15_Jsonclick = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA41ClinicaCodigo = "" ;
         sCtrlA91ConsultaId = "" ;
         Grid1Row = new GXWebRow();
         GXt_char10 = "" ;
         ROClassString = "" ;
         GXt_char11 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wc_cargos__default(),
            new Object[][] {
                new Object[] {
               H001M2_A41ClinicaCodigo, H001M2_A30ArticuloCodigo, H001M2_A31ArticuloDescripcion, H001M2_A34ArticuloEstado
               }
               , new Object[] {
               H001M3_A41ClinicaCodigo, H001M3_A91ConsultaId, H001M3_A31ArticuloDescripcion, H001M3_A30ArticuloCodigo, H001M3_A162CargoId, H001M3_A164CargoCantidad, H001M3_A163CargoPrecio
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
      private short nGXsfl_34_idx=1 ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short GXt_int7 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short wbTemp ;
      private int A91ConsultaId ;
      private int wcpOA91ConsultaId ;
      private int edtavCargoprecio_Enabled ;
      private int A162CargoId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A163CargoPrecio ;
      private decimal A164CargoCantidad ;
      private decimal A165CargoTotal ;
      private decimal AV7CargoPrecio ;
      private decimal AV6CargoCantidad ;
      private decimal GXt_decimal6 ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_34_idx="0001" ;
      private String edtavCargoprecio_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String dynavArticulocodigo_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtConsultaId_Internalname ;
      private String edtCargoId_Internalname ;
      private String edtArticuloCodigo_Internalname ;
      private String edtArticuloDescripcion_Internalname ;
      private String edtCargoPrecio_Internalname ;
      private String edtCargoCantidad_Internalname ;
      private String edtCargoTotal_Internalname ;
      private String GXDecQS ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCargocantidad_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char8 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String GXt_char9 ;
      private String tblTable2_Internalname ;
      private String lblTextblock17_Internalname ;
      private String lblTextblock17_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String TempTags ;
      private String dynavArticulocodigo_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavCargoprecio_Jsonclick ;
      private String edtavCargocantidad_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String sCtrlA41ClinicaCodigo ;
      private String sCtrlA91ConsultaId ;
      private String GXt_char10 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtConsultaId_Jsonclick ;
      private String edtCargoId_Jsonclick ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtArticuloDescripcion_Jsonclick ;
      private String edtCargoPrecio_Jsonclick ;
      private String edtCargoCantidad_Jsonclick ;
      private String edtCargoTotal_Jsonclick ;
      private String GXt_char11 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String wcpOA41ClinicaCodigo ;
      private String A30ArticuloCodigo ;
      private String A31ArticuloDescripcion ;
      private String AV5ArticuloCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private GXCombobox dynavArticulocodigo ;
      private IDataStoreProvider pr_default ;
      private String[] H001M2_A41ClinicaCodigo ;
      private String[] H001M2_A30ArticuloCodigo ;
      private String[] H001M2_A31ArticuloDescripcion ;
      private short[] H001M2_A34ArticuloEstado ;
      private String[] H001M3_A41ClinicaCodigo ;
      private int[] H001M3_A91ConsultaId ;
      private String[] H001M3_A31ArticuloDescripcion ;
      private String[] H001M3_A30ArticuloCodigo ;
      private int[] H001M3_A162CargoId ;
      private decimal[] H001M3_A164CargoCantidad ;
      private decimal[] H001M3_A163CargoPrecio ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class wc_cargos__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001M2 ;
          prmH001M2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH001M3 ;
          prmH001M3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001M2", "SELECT [ClinicaCodigo], [ArticuloCodigo], [ArticuloDescripcion], [ArticuloEstado] FROM [Articulo] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([ArticuloEstado] = 1) ORDER BY [ArticuloDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M2,0,0,true,false )
             ,new CursorDef("H001M3", "SELECT T1.[ClinicaCodigo], T1.[ConsultaId], T2.[ArticuloDescripcion], T1.[ArticuloCodigo], T1.[CargoId], T1.[CargoCantidad], T1.[CargoPrecio] FROM ([Cargo] T1 WITH (NOLOCK) INNER JOIN [Articulo] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[ArticuloCodigo] = T1.[ArticuloCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[ConsultaId] = @ConsultaId ORDER BY T1.[ClinicaCodigo], T1.[ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M3,11,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
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
       }
    }

 }

}
