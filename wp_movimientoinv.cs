/*
               File: wp_movimientoinv
        Description: Consulta de movimientos de inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:58.87
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
   public class wp_movimientoinv : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_movimientoinv( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_movimientoinv( IGxContext context )
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
         cmbMovimientoEstado = new GXCombobox();
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
               nGXsfl_24_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_24_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_24_idx, sGXsfl_24_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               GXCCtl = "MOVIMIENTOESTADO_" + sGXsfl_24_idx ;
               cmbMovimientoEstado.Name = GXCCtl ;
               cmbMovimientoEstado.WebTags = "" ;
               cmbMovimientoEstado.addItem("0", "Creado", 0);
               cmbMovimientoEstado.addItem("1", "Emitido", 0);
               cmbMovimientoEstado.addItem("2", "Anulado", 0);
               cmbMovimientoEstado.addItem("3", "Cancelado", 0);
               if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
               {
                  A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize24 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV7MovimientoFechaD = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MovimientoFechaD", context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"));
               AV8MovimientoFechaA = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MovimientoFechaA", context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"));
               AV5ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize24, AV7MovimientoFechaD, AV8MovimientoFechaA, AV5ClinicaCodigo) ;
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
         PA2X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2X2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_movimientoinv.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vMOVIMIENTOFECHAD", context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vMOVIMIENTOFECHAA", context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV5ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
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
            WE2X2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2X2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_movimientoinv" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de movimientos de inventario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_movimientoinv.aspx")  ;
      }

      protected void WB2X0( )
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
            wb_table1_2_2X2( true) ;
         }
         else
         {
            wb_table1_2_2X2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2X2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2X2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Consulta de movimientos de inventario", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2X0( ) ;
      }

      protected void WS2X2( )
      {
         START2X2( ) ;
         EVT2X2( ) ;
      }

      protected void EVT2X2( )
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
                  /* Check if conditions changed and reset current page numbers */
                  if ( context.localUtil.CToD( cgiGet( "GXH_vMOVIMIENTOFECHAD"), 2) != AV7MovimientoFechaD )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vMOVIMIENTOFECHAA"), 2) != AV8MovimientoFechaA )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                           else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E112X2 */
                              E112X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E122X2 */
                              E122X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E132X2 */
                              E132X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E142X2 */
                              E142X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E152X2 */
                              E152X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E162X2 */
                              E162X2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_24_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
                              edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
                              edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
                              edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
                              edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
                              edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
                              cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A114TipoMICodigo = cgiGet( edtTipoMICodigo_Internalname) ;
                              A267MovimientoId = (int)(context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",")) ;
                              A268MovimientoFecha = context.localUtil.CToD( cgiGet( edtMovimientoFecha_Internalname), 2) ;
                              A121BodegaCodigo = cgiGet( edtBodegaCodigo_Internalname) ;
                              A269MovimientoReferencia = cgiGet( edtMovimientoReferencia_Internalname) ;
                              cmbMovimientoEstado.Name = cmbMovimientoEstado_Internalname ;
                              cmbMovimientoEstado.CurrentValue = cgiGet( cmbMovimientoEstado_Internalname) ;
                              A271MovimientoEstado = (short)(NumberUtil.Val( cgiGet( cmbMovimientoEstado_Internalname), ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E172X2 */
                                    E172X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E182X2 */
                                    E182X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Movimientofechad Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vMOVIMIENTOFECHAD"), 2) != AV7MovimientoFechaD )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Movimientofechaa Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vMOVIMIENTOFECHAA"), 2) != AV8MovimientoFechaA )
                                       {
                                          Rfr0gs = true ;
                                       }
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

      protected void WE2X2( )
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

      protected void PA2X2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXCCtl = "MOVIMIENTOESTADO_" + sGXsfl_24_idx ;
            cmbMovimientoEstado.Name = GXCCtl ;
            cmbMovimientoEstado.WebTags = "" ;
            cmbMovimientoEstado.addItem("0", "Creado", 0);
            cmbMovimientoEstado.addItem("1", "Emitido", 0);
            cmbMovimientoEstado.addItem("2", "Anulado", 0);
            cmbMovimientoEstado.addItem("3", "Cancelado", 0);
            if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
            {
               A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
            }
            GX_FocusControl = edtavMovimientofechad_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_24_idx ,
                                       String sGXsfl_24_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
         edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
         edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
         edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
         cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
         while ( nGXsfl_24_idx <= nRC_Grid1 )
         {
            sendrow_242( ) ;
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize24 ,
                                        DateTime AV7MovimientoFechaD ,
                                        DateTime AV8MovimientoFechaA ,
                                        String AV5ClinicaCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize24) ;
         RF2X2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2X2( ) ;
         /* End function Refresh */
      }

      protected void RF2X2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
         edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
         edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
         edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
         cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
            /* Using cursor H002X2 */
            pr_default.execute(0, new Object[] {AV5ClinicaCodigo, AV7MovimientoFechaD, AV8MovimientoFechaA});
            nGXsfl_24_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 12 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A271MovimientoEstado = H002X2_A271MovimientoEstado[0] ;
               A269MovimientoReferencia = H002X2_A269MovimientoReferencia[0] ;
               A121BodegaCodigo = H002X2_A121BodegaCodigo[0] ;
               A268MovimientoFecha = H002X2_A268MovimientoFecha[0] ;
               A267MovimientoId = H002X2_A267MovimientoId[0] ;
               A114TipoMICodigo = H002X2_A114TipoMICodigo[0] ;
               A41ClinicaCodigo = H002X2_A41ClinicaCodigo[0] ;
               /* Execute user event: E182X2 */
               E182X2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 24 ;
            WB2X0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         /* Using cursor H002X3 */
         pr_default.execute(1, new Object[] {AV5ClinicaCodigo, AV7MovimientoFechaD, AV8MovimientoFechaA});
         GRID1_nRecordCount = H002X3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 12 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(12*1) ;
            }
            else
            {
               return (int)(12) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP2X0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E172X2 */
         E172X2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavMovimientofechad_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Movimiento Fecha D"}), 1, "vMOVIMIENTOFECHAD");
               GX_FocusControl = edtavMovimientofechad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7MovimientoFechaD = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MovimientoFechaD", context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"));
            }
            else
            {
               AV7MovimientoFechaD = context.localUtil.CToD( cgiGet( edtavMovimientofechad_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MovimientoFechaD", context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavMovimientofechaa_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Movimiento Fecha A"}), 1, "vMOVIMIENTOFECHAA");
               GX_FocusControl = edtavMovimientofechaa_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8MovimientoFechaA = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MovimientoFechaA", context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"));
            }
            else
            {
               AV8MovimientoFechaA = context.localUtil.CToD( cgiGet( edtavMovimientofechaa_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MovimientoFechaA", context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
            /* Read subfile selected row values. */
            nGXsfl_24_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ".", ",")) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
            if ( nGXsfl_24_idx > 0 )
            {
               A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
               A114TipoMICodigo = cgiGet( edtTipoMICodigo_Internalname) ;
               A267MovimientoId = (int)(context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",")) ;
               A268MovimientoFecha = context.localUtil.CToD( cgiGet( edtMovimientoFecha_Internalname), 2) ;
               A121BodegaCodigo = cgiGet( edtBodegaCodigo_Internalname) ;
               A269MovimientoReferencia = cgiGet( edtMovimientoReferencia_Internalname) ;
               cmbMovimientoEstado.Name = cmbMovimientoEstado_Internalname ;
               cmbMovimientoEstado.CurrentValue = cgiGet( cmbMovimientoEstado_Internalname) ;
               A271MovimientoEstado = (short)(NumberUtil.Val( cgiGet( cmbMovimientoEstado_Internalname), ".")) ;
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E172X2 */
         E172X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E172X2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV6Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV6Parametros = GXt_SdtParametros4 ;
         AV5ClinicaCodigo = AV6Parametros.gxTpr_Pclinicacodigo ;
         AV7MovimientoFechaD = context.localUtil.YMDToD( DateTimeUtil.Year( Gx_date), DateTimeUtil.Month( Gx_date), 1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MovimientoFechaD", context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"));
         AV8MovimientoFechaA = DateTimeUtil.DateEndOfMonth( AV7MovimientoFechaD) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MovimientoFechaA", context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"));
      }

      protected void E112X2( )
      {
         /* 'First' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E122X2( )
      {
         /* 'Previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E132X2( )
      {
         /* 'Next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E142X2( )
      {
         /* 'Last' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void E152X2( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      protected void E162X2( )
      {
         /* 'Nuevo' Routine */
         context.wjLoc = formatLink("wp_registramovinv.aspx")  ;
      }

      private void E182X2( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 12 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_242( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_2_2X2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Movimientos de Inventario", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_movimientoinv.htm");
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:67px\">") ;
            wb_table2_11_2X2( true) ;
         }
         else
         {
            wb_table2_11_2X2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_2X2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"24\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Tipo_Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Bodega") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Referencia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Movimiento Estado") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A114TipoMICodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A121BodegaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A269MovimientoReferencia));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A271MovimientoEstado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 24 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_24_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "|<", bttButton1_Jsonclick, 5, "|<", "", StyleString, ClassString, 1, 1, "standard", "E\\'FIRST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "<", bttButton2_Jsonclick, 5, "<", "", StyleString, ClassString, 1, 1, "standard", "E\\'PREVIOUS\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", ">", bttButton3_Jsonclick, 5, ">", "", StyleString, ClassString, 1, 1, "standard", "E\\'NEXT\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", ">|", bttButton4_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'LAST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton6_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "Nuevo", bttButton6_Jsonclick, 5, "Nuevo", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVO\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "Regresar", bttButton5_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2X2e( true) ;
         }
         else
         {
            wb_table1_2_2X2e( false) ;
         }
      }

      protected void wb_table2_11_2X2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Fecha Del", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Fecha Al", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_movimientoinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MovimientoFechaD", context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavMovimientofechad_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientofechad_Internalname, context.localUtil.Format(AV7MovimientoFechaD, "99/99/99"), context.localUtil.Format( AV7MovimientoFechaD, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(19);\"", "", "", "", "", edtavMovimientofechad_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_movimientoinv.htm");
            GxWebStd.gx_bitmap( context, edtavMovimientofechad_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_movimientoinv.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MovimientoFechaA", context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavMovimientofechaa_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientofechaa_Internalname, context.localUtil.Format(AV8MovimientoFechaA, "99/99/99"), context.localUtil.Format( AV8MovimientoFechaA, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(21);\"", "", "", "", "", edtavMovimientofechaa_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_movimientoinv.htm");
            GxWebStd.gx_bitmap( context, edtavMovimientofechaa_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_movimientoinv.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_2X2e( true) ;
         }
         else
         {
            wb_table2_11_2X2e( false) ;
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
         PA2X2( ) ;
         WS2X2( ) ;
         WE2X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1575941");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_movimientoinv.js", "?1575941");
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB2X0( ) ;
         if ( ( 12 * 1 == 0 ) || ( nGXsfl_24_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
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
               if ( ((int)(nGXsfl_24_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_24_idx+"\">") ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoMICodigo_Internalname,StringUtil.RTrim( A114TipoMICodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoMICodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A267MovimientoId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoFecha_Internalname,context.localUtil.Format(A268MovimientoFecha, "99/99/99"),context.localUtil.Format( A268MovimientoFecha, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodegaCodigo_Internalname,StringUtil.RTrim( A121BodegaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtBodegaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoReferencia_Internalname,StringUtil.RTrim( A269MovimientoReferencia),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoReferencia_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            if ( ( nGXsfl_24_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "MOVIMIENTOESTADO_" + sGXsfl_24_idx ;
               cmbMovimientoEstado.Name = GXCCtl ;
               cmbMovimientoEstado.WebTags = "" ;
               cmbMovimientoEstado.addItem("0", "Creado", 0);
               cmbMovimientoEstado.addItem("1", "Emitido", 0);
               cmbMovimientoEstado.addItem("2", "Anulado", 0);
               cmbMovimientoEstado.addItem("3", "Cancelado", 0);
               if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
               {
                  A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbMovimientoEstado,(String)cmbMovimientoEstado_Internalname,StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0),(short)1,(String)cmbMovimientoEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbMovimientoEstado.CurrentValue = StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientoEstado_Internalname, "Values", (String)(cmbMovimientoEstado.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_24_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_24_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_24_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_24_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_24_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_24_idx ;
         }
         /* End function sendrow_242 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtavMovimientofechad_Internalname = "vMOVIMIENTOFECHAD" ;
         edtavMovimientofechaa_Internalname = "vMOVIMIENTOFECHAA" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton6_Internalname = "BUTTON6" ;
         bttButton5_Internalname = "BUTTON5" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbMovimientoEstado_Jsonclick = "" ;
         edtMovimientoReferencia_Jsonclick = "" ;
         edtBodegaCodigo_Jsonclick = "" ;
         edtMovimientoFecha_Jsonclick = "" ;
         edtMovimientoId_Jsonclick = "" ;
         edtTipoMICodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavMovimientofechaa_Jsonclick = "" ;
         edtavMovimientofechad_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de movimientos de inventario" ;
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
         Gx_date = DateTime.MinValue ;
         GXCCtl = "" ;
         AV7MovimientoFechaD = DateTime.MinValue ;
         AV8MovimientoFechaA = DateTime.MinValue ;
         AV5ClinicaCodigo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtTipoMICodigo_Internalname = "" ;
         edtMovimientoId_Internalname = "" ;
         edtMovimientoFecha_Internalname = "" ;
         edtBodegaCodigo_Internalname = "" ;
         edtMovimientoReferencia_Internalname = "" ;
         cmbMovimientoEstado_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A114TipoMICodigo = "" ;
         A268MovimientoFecha = DateTime.MinValue ;
         A121BodegaCodigo = "" ;
         A269MovimientoReferencia = "" ;
         GXKey = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H002X2_A271MovimientoEstado = new short[1] ;
         H002X2_A269MovimientoReferencia = new String[] {""} ;
         H002X2_A121BodegaCodigo = new String[] {""} ;
         H002X2_A268MovimientoFecha = new DateTime[] {DateTime.MinValue} ;
         H002X2_A267MovimientoId = new int[1] ;
         H002X2_A114TipoMICodigo = new String[] {""} ;
         H002X2_A41ClinicaCodigo = new String[] {""} ;
         H002X3_AGRID1_nRecordCount = new int[1] ;
         AV6Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton6_Jsonclick = "" ;
         bttButton5_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         GXt_char7 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_movimientoinv__default(),
            new Object[][] {
                new Object[] {
               H002X2_A271MovimientoEstado, H002X2_A269MovimientoReferencia, H002X2_A121BodegaCodigo, H002X2_A268MovimientoFecha, H002X2_A267MovimientoId, H002X2_A114TipoMICodigo, H002X2_A41ClinicaCodigo
               }
               , new Object[] {
               H002X3_AGRID1_nRecordCount
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_24_idx=1 ;
      private short A271MovimientoEstado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize24 ;
      private int GRID1_nFirstRecordOnPage ;
      private int A267MovimientoId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String GXCCtl ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtTipoMICodigo_Internalname ;
      private String edtMovimientoId_Internalname ;
      private String edtMovimientoFecha_Internalname ;
      private String edtBodegaCodigo_Internalname ;
      private String edtMovimientoReferencia_Internalname ;
      private String cmbMovimientoEstado_Internalname ;
      private String GXKey ;
      private String edtavMovimientofechad_Internalname ;
      private String scmdbuf ;
      private String edtavMovimientofechaa_Internalname ;
      private String subGrid1_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton6_Internalname ;
      private String bttButton6_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavMovimientofechad_Jsonclick ;
      private String edtavMovimientofechaa_Jsonclick ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoMICodigo_Jsonclick ;
      private String edtMovimientoId_Jsonclick ;
      private String edtMovimientoFecha_Jsonclick ;
      private String edtBodegaCodigo_Jsonclick ;
      private String edtMovimientoReferencia_Jsonclick ;
      private String cmbMovimientoEstado_Jsonclick ;
      private String GXt_char9 ;
      private DateTime Gx_date ;
      private DateTime AV7MovimientoFechaD ;
      private DateTime AV8MovimientoFechaA ;
      private DateTime A268MovimientoFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String A121BodegaCodigo ;
      private String A269MovimientoReferencia ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbMovimientoEstado ;
      private IDataStoreProvider pr_default ;
      private short[] H002X2_A271MovimientoEstado ;
      private String[] H002X2_A269MovimientoReferencia ;
      private String[] H002X2_A121BodegaCodigo ;
      private DateTime[] H002X2_A268MovimientoFecha ;
      private int[] H002X2_A267MovimientoId ;
      private String[] H002X2_A114TipoMICodigo ;
      private String[] H002X2_A41ClinicaCodigo ;
      private int[] H002X3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV6Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_movimientoinv__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002X2 ;
          prmH002X2 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7MovimientoFechaD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8MovimientoFechaA",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmH002X3 ;
          prmH002X3 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7MovimientoFechaD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8MovimientoFechaA",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002X2", "SELECT [MovimientoEstado], [MovimientoReferencia], [BodegaCodigo], [MovimientoFecha], [MovimientoId], [TipoMICodigo], [ClinicaCodigo] FROM [MovimientoInv] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV5ClinicaCodigo) AND ([MovimientoFecha] >= @AV7MovimientoFechaD) AND ([MovimientoFecha] <= @AV8MovimientoFechaA) ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId]  OPTION (FAST 13)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002X2,13,0,true,false )
             ,new CursorDef("H002X3", "SELECT COUNT(*) FROM [MovimientoInv] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV5ClinicaCodigo) AND ([MovimientoFecha] >= @AV7MovimientoFechaD) AND ([MovimientoFecha] <= @AV8MovimientoFechaA) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002X3,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
       }
    }

 }

}
