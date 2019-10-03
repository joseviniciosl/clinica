/*
               File: Gx01O2
        Description: Selection List Detalle de Factura a Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:34.8
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
   public class gx01o2 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01o2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01o2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           int aP1_pFacturaId ,
                           out int aP2_pFacturaDId )
      {
         this.AV10pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV11pFacturaId = aP1_pFacturaId;
         this.AV12pFacturaDId = 0 ;
         executePrivate();
         aP2_pFacturaDId=this.AV12pFacturaDId;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_36_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_36_idx, sGXsfl_36_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize36 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cFacturaDId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cFacturaDId), 9, 0)));
               AV8cFacturaDPrecio = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cFacturaDPrecio", StringUtil.LTrim( StringUtil.Str( AV8cFacturaDPrecio, 17, 2)));
               AV9cFacturaDCantidad = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cFacturaDCantidad", StringUtil.LTrim( StringUtil.Str( AV9cFacturaDCantidad, 17, 2)));
               AV13cArticuloCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cArticuloCodigo", AV13cArticuloCodigo);
               AV10pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
               AV11pFacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pFacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pFacturaId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV6cFacturaDId, AV8cFacturaDPrecio, AV9cFacturaDCantidad, AV13cArticuloCodigo, AV10pClinicaCodigo, AV11pFacturaId) ;
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
               AV10pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11pFacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pFacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pFacturaId), 9, 0)));
                  AV12pFacturaDId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pFacturaDId), 9, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA2L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2L2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01o2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pClinicaCodigo)) + "," + UrlEncode("" +AV11pFacturaId) + "," + UrlEncode("" +AV12pFacturaDId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCFACTURADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cFacturaDId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFACTURADPRECIO", StringUtil.LTrim( StringUtil.NToC( AV8cFacturaDPrecio, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFACTURADCANTIDAD", StringUtil.LTrim( StringUtil.NToC( AV9cFacturaDCantidad, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOCODIGO", StringUtil.RTrim( AV13cArticuloCodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV10pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPFACTURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pFacturaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPFACTURADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pFacturaDId), 9, 0, ".", "")));
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
            WE2L2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01O2" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Detalle de Factura a Pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01o2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pClinicaCodigo)) + "," + UrlEncode("" +AV11pFacturaId) + "," + UrlEncode("" +AV12pFacturaDId) ;
      }

      protected void WB2L0( )
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
            wb_table1_2_2L2( true) ;
         }
         else
         {
            wb_table1_2_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2L2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Detalle de Factura a Pacientes", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2L0( ) ;
      }

      protected void WS2L2( )
      {
         START2L2( ) ;
         EVT2L2( ) ;
      }

      protected void EVT2L2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFACTURADID"), ".", ",") != Convert.ToDecimal( AV6cFacturaDId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCFACTURADPRECIO"), ".", ",") != AV8cFacturaDPrecio )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCFACTURADCANTIDAD"), ".", ",") != AV9cFacturaDCantidad )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULOCODIGO"), AV13cArticuloCodigo) != 0 )
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
                              edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_36_idx ;
                              edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_36_idx ;
                              edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_36_idx ;
                              edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_36_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
                              edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_36_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A248FacturaDId = (int)(context.localUtil.CToN( cgiGet( edtFacturaDId_Internalname), ".", ",")) ;
                              A249FacturaDPrecio = context.localUtil.CToN( cgiGet( edtFacturaDPrecio_Internalname), ".", ",") ;
                              A250FacturaDCantidad = context.localUtil.CToN( cgiGet( edtFacturaDCantidad_Internalname), ".", ",") ;
                              A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A185FacturaId = (int)(context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112L2 */
                                    E112L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122L2 */
                                    E122L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cfacturadid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFACTURADID"), ".", ",") != Convert.ToDecimal( AV6cFacturaDId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cfacturadprecio Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCFACTURADPRECIO"), ".", ",") != AV8cFacturaDPrecio )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cfacturadcantidad Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCFACTURADCANTIDAD"), ".", ",") != AV9cFacturaDCantidad )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Carticulocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULOCODIGO"), AV13cArticuloCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132L2 */
                                          E132L2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
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

      protected void WE2L2( )
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

      protected void PA2L2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCfacturadid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_36_idx ,
                                       String sGXsfl_36_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_36_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_36_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_36_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_36_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_36_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_36_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_36_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        int AV6cFacturaDId ,
                                        decimal AV8cFacturaDPrecio ,
                                        decimal AV9cFacturaDCantidad ,
                                        String AV13cArticuloCodigo ,
                                        String AV10pClinicaCodigo ,
                                        int AV11pFacturaId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF2L2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2L2( ) ;
         /* End function Refresh */
      }

      protected void RF2L2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_36_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_36_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_36_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_36_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_36_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_36_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_36_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_36_idx ;
            lV13cArticuloCodigo = StringUtil.PadR( StringUtil.RTrim( AV13cArticuloCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cArticuloCodigo", AV13cArticuloCodigo);
            /* Using cursor H002L2 */
            pr_default.execute(0, new Object[] {AV10pClinicaCodigo, AV11pFacturaId, AV6cFacturaDId, AV8cFacturaDPrecio, AV9cFacturaDCantidad, lV13cArticuloCodigo});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A185FacturaId = H002L2_A185FacturaId[0] ;
               A41ClinicaCodigo = H002L2_A41ClinicaCodigo[0] ;
               A30ArticuloCodigo = H002L2_A30ArticuloCodigo[0] ;
               A250FacturaDCantidad = H002L2_A250FacturaDCantidad[0] ;
               A249FacturaDPrecio = H002L2_A249FacturaDPrecio[0] ;
               A248FacturaDId = H002L2_A248FacturaDId[0] ;
               /* Execute user event: E122L2 */
               E122L2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 36 ;
            WB2L0( ) ;
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
         lV13cArticuloCodigo = StringUtil.PadR( StringUtil.RTrim( AV13cArticuloCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cArticuloCodigo", AV13cArticuloCodigo);
         /* Using cursor H002L3 */
         pr_default.execute(1, new Object[] {AV10pClinicaCodigo, AV11pFacturaId, AV6cFacturaDId, AV8cFacturaDPrecio, AV9cFacturaDCantidad, lV13cArticuloCodigo});
         GRID1_nRecordCount = H002L3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
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

      protected void STRUP2L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112L2 */
         E112L2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCfacturadid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCfacturadid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFACTURADID");
               GX_FocusControl = edtavCfacturadid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cFacturaDId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cFacturaDId), 9, 0)));
            }
            else
            {
               AV6cFacturaDId = (int)(context.localUtil.CToN( cgiGet( edtavCfacturadid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cFacturaDId), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCfacturadprecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCfacturadprecio_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFACTURADPRECIO");
               GX_FocusControl = edtavCfacturadprecio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cFacturaDPrecio = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cFacturaDPrecio", StringUtil.LTrim( StringUtil.Str( AV8cFacturaDPrecio, 17, 2)));
            }
            else
            {
               AV8cFacturaDPrecio = context.localUtil.CToN( cgiGet( edtavCfacturadprecio_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cFacturaDPrecio", StringUtil.LTrim( StringUtil.Str( AV8cFacturaDPrecio, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCfacturadcantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCfacturadcantidad_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFACTURADCANTIDAD");
               GX_FocusControl = edtavCfacturadcantidad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cFacturaDCantidad = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cFacturaDCantidad", StringUtil.LTrim( StringUtil.Str( AV9cFacturaDCantidad, 17, 2)));
            }
            else
            {
               AV9cFacturaDCantidad = context.localUtil.CToN( cgiGet( edtavCfacturadcantidad_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cFacturaDCantidad", StringUtil.LTrim( StringUtil.Str( AV9cFacturaDCantidad, 17, 2)));
            }
            AV13cArticuloCodigo = cgiGet( edtavCarticulocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cArticuloCodigo", AV13cArticuloCodigo);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV10pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV11pFacturaId = (int)(context.localUtil.CToN( cgiGet( "vPFACTURAID"), ".", ",")) ;
            AV12pFacturaDId = (int)(context.localUtil.CToN( cgiGet( "vPFACTURADID"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
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
         /* Execute user event: E112L2 */
         E112L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112L2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Detalle de Factura a Pacientes", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122L2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_362( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132L2 */
         E132L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132L2( )
      {
         /* Enter Routine */
         AV12pFacturaDId = A248FacturaDId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pFacturaDId), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV12pFacturaDId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_2L2( true) ;
         }
         else
         {
            wb_table2_9_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_33_2L2( true) ;
         }
         else
         {
            wb_table3_33_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2L2e( true) ;
         }
         else
         {
            wb_table1_2_2L2e( false) ;
         }
      }

      protected void wb_table3_33_2L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"36\">") ;
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Línea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Precio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Artículo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Factura") ;
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
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtFacturaDPrecio_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 36 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_36_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_46_2L2( true) ;
         }
         else
         {
            wb_table4_46_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table4_46_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_2L2e( true) ;
         }
         else
         {
            wb_table3_33_2L2e( false) ;
         }
      }

      protected void wb_table4_46_2L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_46_2L2e( true) ;
         }
         else
         {
            wb_table4_46_2L2e( false) ;
         }
      }

      protected void wb_table2_9_2L2( bool wbgen )
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
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturadid_Internalname, "Línea", "", "", lblTextblockfacturadid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cFacturaDId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCfacturadid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cFacturaDId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cFacturaDId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cFacturaDId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavCfacturadid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturadprecio_Internalname, "Precio", "", "", lblTextblockfacturadprecio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cFacturaDPrecio", StringUtil.LTrim( StringUtil.Str( AV8cFacturaDPrecio, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCfacturadprecio_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cFacturaDPrecio, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cFacturaDPrecio, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV8cFacturaDPrecio, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCfacturadprecio_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturadcantidad_Internalname, "Cantidad", "", "", lblTextblockfacturadcantidad_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cFacturaDCantidad", StringUtil.LTrim( StringUtil.Str( AV9cFacturaDCantidad, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCfacturadcantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cFacturaDCantidad, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cFacturaDCantidad, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV9cFacturaDCantidad, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCfacturadcantidad_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulocodigo_Internalname, "Artículo", "", "", lblTextblockarticulocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cArticuloCodigo", AV13cArticuloCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCarticulocodigo_Internalname, StringUtil.RTrim( AV13cArticuloCodigo), StringUtil.RTrim( context.localUtil.Format( AV13cArticuloCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavCarticulocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01O2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2L2e( true) ;
         }
         else
         {
            wb_table2_9_2L2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
         AV11pFacturaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pFacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pFacturaId), 9, 0)));
         AV12pFacturaDId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pFacturaDId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pFacturaDId), 9, 0)));
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
         PA2L2( ) ;
         WS2L2( ) ;
         WE2L2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1593469");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("gx01o2.js", "?1593469");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB2L0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               subGrid1_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_36_idx) % (2)) == 0 )
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
                  subGrid1_Backcolor = (int)(0xFFFFFF) ;
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_36_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")))+"'"+"]);" ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)AV5LinkSelection,(String)edtavLinkselection_Link,(String)"",(String)"",(String)"Fantastic",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A248FacturaDId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtFacturaDPrecio_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", "")),context.localUtil.Format( A249FacturaDPrecio, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)edtFacturaDPrecio_Link,(String)"",(String)"Seleccionar",(String)edtFacturaDPrecio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", "")),context.localUtil.Format( A250FacturaDCantidad, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDCantidad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_36_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_36_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_36_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblockfacturadid_Internalname = "TEXTBLOCKFACTURADID" ;
         edtavCfacturadid_Internalname = "vCFACTURADID" ;
         lblTextblockfacturadprecio_Internalname = "TEXTBLOCKFACTURADPRECIO" ;
         edtavCfacturadprecio_Internalname = "vCFACTURADPRECIO" ;
         lblTextblockfacturadcantidad_Internalname = "TEXTBLOCKFACTURADCANTIDAD" ;
         edtavCfacturadcantidad_Internalname = "vCFACTURADCANTIDAD" ;
         lblTextblockarticulocodigo_Internalname = "TEXTBLOCKARTICULOCODIGO" ;
         edtavCarticulocodigo_Internalname = "vCARTICULOCODIGO" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtFacturaId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtFacturaDCantidad_Jsonclick = "" ;
         edtFacturaDPrecio_Jsonclick = "" ;
         edtFacturaDId_Jsonclick = "" ;
         edtavCarticulocodigo_Jsonclick = "" ;
         edtavCfacturadcantidad_Jsonclick = "" ;
         edtavCfacturadprecio_Jsonclick = "" ;
         edtavCfacturadid_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtFacturaDPrecio_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Detalle de Factura a Pacientes" ;
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
         wcpOAV10pClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV13cArticuloCodigo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtFacturaDId_Internalname = "" ;
         edtFacturaDPrecio_Internalname = "" ;
         edtFacturaDCantidad_Internalname = "" ;
         edtArticuloCodigo_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtFacturaId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A30ArticuloCodigo = "" ;
         A41ClinicaCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV13cArticuloCodigo = "" ;
         H002L2_A185FacturaId = new int[1] ;
         H002L2_A41ClinicaCodigo = new String[] {""} ;
         H002L2_A30ArticuloCodigo = new String[] {""} ;
         H002L2_A250FacturaDCantidad = new decimal[1] ;
         H002L2_A249FacturaDPrecio = new decimal[1] ;
         H002L2_A248FacturaDId = new int[1] ;
         H002L3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockfacturadid_Jsonclick = "" ;
         lblTextblockfacturadprecio_Jsonclick = "" ;
         lblTextblockfacturadcantidad_Jsonclick = "" ;
         lblTextblockarticulocodigo_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01o2__default(),
            new Object[][] {
                new Object[] {
               H002L2_A185FacturaId, H002L2_A41ClinicaCodigo, H002L2_A30ArticuloCodigo, H002L2_A250FacturaDCantidad, H002L2_A249FacturaDPrecio, H002L2_A248FacturaDId
               }
               , new Object[] {
               H002L3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_36_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV11pFacturaId ;
      private int wcpOAV11pFacturaId ;
      private int Grid1_PageSize36 ;
      private int AV6cFacturaDId ;
      private int AV12pFacturaDId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A248FacturaDId ;
      private int A185FacturaId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV8cFacturaDPrecio ;
      private decimal AV9cFacturaDCantidad ;
      private decimal A249FacturaDPrecio ;
      private decimal A250FacturaDCantidad ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtFacturaDId_Internalname ;
      private String edtFacturaDPrecio_Internalname ;
      private String edtFacturaDCantidad_Internalname ;
      private String edtArticuloCodigo_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtFacturaId_Internalname ;
      private String edtavCfacturadid_Internalname ;
      private String scmdbuf ;
      private String edtavCfacturadprecio_Internalname ;
      private String edtavCfacturadcantidad_Internalname ;
      private String edtavCarticulocodigo_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String edtavLinkselection_Link ;
      private String edtFacturaDPrecio_Link ;
      private String GXt_char6 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockfacturadid_Internalname ;
      private String lblTextblockfacturadid_Jsonclick ;
      private String edtavCfacturadid_Jsonclick ;
      private String lblTextblockfacturadprecio_Internalname ;
      private String lblTextblockfacturadprecio_Jsonclick ;
      private String edtavCfacturadprecio_Jsonclick ;
      private String lblTextblockfacturadcantidad_Internalname ;
      private String lblTextblockfacturadcantidad_Jsonclick ;
      private String edtavCfacturadcantidad_Jsonclick ;
      private String lblTextblockarticulocodigo_Internalname ;
      private String lblTextblockarticulocodigo_Jsonclick ;
      private String edtavCarticulocodigo_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtFacturaDId_Jsonclick ;
      private String edtFacturaDPrecio_Jsonclick ;
      private String edtFacturaDCantidad_Jsonclick ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtFacturaId_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV10pClinicaCodigo ;
      private String wcpOAV10pClinicaCodigo ;
      private String AV13cArticuloCodigo ;
      private String A30ArticuloCodigo ;
      private String A41ClinicaCodigo ;
      private String lV13cArticuloCodigo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H002L2_A185FacturaId ;
      private String[] H002L2_A41ClinicaCodigo ;
      private String[] H002L2_A30ArticuloCodigo ;
      private decimal[] H002L2_A250FacturaDCantidad ;
      private decimal[] H002L2_A249FacturaDPrecio ;
      private int[] H002L2_A248FacturaDId ;
      private int[] H002L3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP2_pFacturaDId ;
      private GXWebForm Form ;
   }

   public class gx01o2__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002L2 ;
          prmH002L2 = new Object[] {
          new Object[] {"@AV10pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11pFacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cFacturaDId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cFacturaDPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV9cFacturaDCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@lV13cArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH002L3 ;
          prmH002L3 = new Object[] {
          new Object[] {"@AV10pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11pFacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cFacturaDId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cFacturaDPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV9cFacturaDCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@lV13cArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002L2", "SELECT [FacturaId], [ClinicaCodigo], [ArticuloCodigo], [FacturaDCantidad], [FacturaDPrecio], [FacturaDId] FROM [FacturaDetalle] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV10pClinicaCodigo and [FacturaId] = @AV11pFacturaId and [FacturaDId] >= @AV6cFacturaDId) AND ([FacturaDPrecio] >= @AV8cFacturaDPrecio) AND ([FacturaDCantidad] >= @AV9cFacturaDCantidad) AND ([ArticuloCodigo] like @lV13cArticuloCodigo) ORDER BY [ClinicaCodigo], [FacturaId], [FacturaDId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002L2,11,0,false,false )
             ,new CursorDef("H002L3", "SELECT COUNT(*) FROM [FacturaDetalle] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV10pClinicaCodigo and [FacturaId] = @AV11pFacturaId and [FacturaDId] >= @AV6cFacturaDId) AND ([FacturaDPrecio] >= @AV8cFacturaDPrecio) AND ([FacturaDCantidad] >= @AV9cFacturaDCantidad) AND ([ArticuloCodigo] like @lV13cArticuloCodigo) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002L3,1,0,false,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
