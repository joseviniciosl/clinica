/*
               File: Gx00C1
        Description: Selection List Maestro de productos y servicios
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:37.29
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
   public class gx00c1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00c1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00c1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           out String aP1_pArticuloCodigo )
      {
         this.AV12pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV13pArticuloCodigo = "" ;
         executePrivate();
         aP1_pArticuloCodigo=this.AV13pArticuloCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavCcategoriacodigo = new GXCombobox();
         dynCategoriaCodigo = new GXCombobox();
         cmbArticuloTipo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vCCATEGORIACODIGO") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvCCATEGORIACODIGO2Q2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"CATEGORIACODIGO") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLACATEGORIACODIGO2Q2( ) ;
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
               nGXsfl_46_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_46_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_46_idx, sGXsfl_46_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               dynavCcategoriacodigo.Name = "vCCATEGORIACODIGO" ;
               dynavCcategoriacodigo.WebTags = "" ;
               GXCCtl = "CATEGORIACODIGO_" + sGXsfl_46_idx ;
               dynCategoriaCodigo.Name = GXCCtl ;
               dynCategoriaCodigo.WebTags = "" ;
               GXCCtl = "ARTICULOTIPO_" + sGXsfl_46_idx ;
               cmbArticuloTipo.Name = GXCCtl ;
               cmbArticuloTipo.WebTags = "" ;
               cmbArticuloTipo.addItem("0", "Servicio", 0);
               cmbArticuloTipo.addItem("1", "Producto", 0);
               if ( ( cmbArticuloTipo.ItemCount > 0 ) && (0==A33ArticuloTipo) )
               {
                  A33ArticuloTipo = (short)(NumberUtil.Val( cmbArticuloTipo.getItemValue(1), ".")) ;
               }
               Grid1_PageSize46 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cArticuloCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cArticuloCodigo", AV6cArticuloCodigo);
               AV7cArticuloDescripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cArticuloDescripcion", AV7cArticuloDescripcion);
               AV8cArticuloPrecio = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cArticuloPrecio", StringUtil.LTrim( StringUtil.Str( AV8cArticuloPrecio, 17, 2)));
               AV9cArticuloCosto = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cArticuloCosto", StringUtil.LTrim( StringUtil.Str( AV9cArticuloCosto, 17, 2)));
               AV10cCategoriaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCategoriaCodigo", AV10cCategoriaCodigo);
               AV11cSubCategoriaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cSubCategoriaCodigo", AV11cSubCategoriaCodigo);
               AV12pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize46, AV6cArticuloCodigo, AV7cArticuloDescripcion, AV8cArticuloPrecio, AV9cArticuloCosto, AV10cCategoriaCodigo, AV11cSubCategoriaCodigo, AV12pClinicaCodigo) ;
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
               AV12pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pArticuloCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pArticuloCodigo", AV13pArticuloCodigo);
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
         PA2Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2Q2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00c1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV13pArticuloCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOCODIGO", StringUtil.RTrim( AV6cArticuloCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULODESCRIPCION", StringUtil.RTrim( AV7cArticuloDescripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOPRECIO", StringUtil.LTrim( StringUtil.NToC( AV8cArticuloPrecio, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOCOSTO", StringUtil.LTrim( StringUtil.NToC( AV9cArticuloCosto, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCATEGORIACODIGO", StringUtil.RTrim( AV10cCategoriaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCSUBCATEGORIACODIGO", StringUtil.RTrim( AV11cSubCategoriaCodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV12pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPARTICULOCODIGO", StringUtil.RTrim( AV13pArticuloCodigo));
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
            WE2Q2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2Q2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00C1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Maestro de productos y servicios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00c1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV13pArticuloCodigo)) ;
      }

      protected void WB2Q0( )
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
            wb_table1_2_2Q2( true) ;
         }
         else
         {
            wb_table1_2_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2Q2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2Q2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Maestro de productos y servicios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2Q0( ) ;
      }

      protected void WS2Q2( )
      {
         START2Q2( ) ;
         EVT2Q2( ) ;
      }

      protected void EVT2Q2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULOCODIGO"), AV6cArticuloCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULODESCRIPCION"), AV7cArticuloDescripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOPRECIO"), ".", ",") != AV8cArticuloPrecio )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOCOSTO"), ".", ",") != AV9cArticuloCosto )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCATEGORIACODIGO"), AV10cCategoriaCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCSUBCATEGORIACODIGO"), AV11cSubCategoriaCodigo) != 0 )
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
                              nGXsfl_46_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
                              edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_46_idx ;
                              edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_46_idx ;
                              dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_46_idx ;
                              cmbArticuloTipo_Internalname = "ARTICULOTIPO_"+sGXsfl_46_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
                              A31ArticuloDescripcion = cgiGet( edtArticuloDescripcion_Internalname) ;
                              dynCategoriaCodigo.Name = dynCategoriaCodigo_Internalname ;
                              dynCategoriaCodigo.CurrentValue = cgiGet( dynCategoriaCodigo_Internalname) ;
                              A27CategoriaCodigo = cgiGet( dynCategoriaCodigo_Internalname) ;
                              cmbArticuloTipo.Name = cmbArticuloTipo_Internalname ;
                              cmbArticuloTipo.CurrentValue = cgiGet( cmbArticuloTipo_Internalname) ;
                              A33ArticuloTipo = (short)(NumberUtil.Val( cgiGet( cmbArticuloTipo_Internalname), ".")) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112Q2 */
                                    E112Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122Q2 */
                                    E122Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Carticulocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULOCODIGO"), AV6cArticuloCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Carticulodescripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULODESCRIPCION"), AV7cArticuloDescripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Carticuloprecio Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOPRECIO"), ".", ",") != AV8cArticuloPrecio )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Carticulocosto Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOCOSTO"), ".", ",") != AV9cArticuloCosto )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccategoriacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCATEGORIACODIGO"), AV10cCategoriaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csubcategoriacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSUBCATEGORIACODIGO"), AV11cSubCategoriaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132Q2 */
                                          E132Q2 ();
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

      protected void WE2Q2( )
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

      protected void PA2Q2( )
      {
         if ( nDonePA == 0 )
         {
            dynavCcategoriacodigo.Name = "vCCATEGORIACODIGO" ;
            dynavCcategoriacodigo.WebTags = "" ;
            GXCCtl = "CATEGORIACODIGO_" + sGXsfl_46_idx ;
            dynCategoriaCodigo.Name = GXCCtl ;
            dynCategoriaCodigo.WebTags = "" ;
            GXCCtl = "ARTICULOTIPO_" + sGXsfl_46_idx ;
            cmbArticuloTipo.Name = GXCCtl ;
            cmbArticuloTipo.WebTags = "" ;
            cmbArticuloTipo.addItem("0", "Servicio", 0);
            cmbArticuloTipo.addItem("1", "Producto", 0);
            if ( ( cmbArticuloTipo.ItemCount > 0 ) && (0==A33ArticuloTipo) )
            {
               A33ArticuloTipo = (short)(NumberUtil.Val( cmbArticuloTipo.getItemValue(1), ".")) ;
            }
            GX_FocusControl = edtavCarticulocodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvCCATEGORIACODIGO2Q2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvCCATEGORIACODIGO_data2Q2( ) ;
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

      protected void GXVvCCATEGORIACODIGO_html2Q2( )
      {
         String gxdynajaxvalue ;
         GXDLVvCCATEGORIACODIGO_data2Q2( ) ;
         gxdynajaxindex = 1 ;
         dynavCcategoriacodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavCcategoriacodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavCcategoriacodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10cCategoriaCodigo)) )
            {
               AV10cCategoriaCodigo = dynavCcategoriacodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCategoriaCodigo", AV10cCategoriaCodigo);
            }
         }
      }

      protected void GXDLVvCCATEGORIACODIGO_data2Q2( )
      {
         /* Using cursor H002Q2 */
         pr_default.execute(0);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H002Q2_A27CategoriaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002Q2_A28CategoriaDescripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLACATEGORIACODIGO2Q2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLACATEGORIACODIGO_data2Q2( ) ;
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

      protected void GXACATEGORIACODIGO_html2Q2( )
      {
         String gxdynajaxvalue ;
         GXDLACATEGORIACODIGO_data2Q2( ) ;
         gxdynajaxindex = 1 ;
         dynCategoriaCodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynCategoriaCodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLACATEGORIACODIGO_data2Q2( )
      {
         /* Using cursor H002Q3 */
         pr_default.execute(1);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H002Q3_A27CategoriaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002Q3_A28CategoriaDescripcion[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_46_idx ,
                                       String sGXsfl_46_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_46_idx ;
         edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_46_idx ;
         dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_46_idx ;
         cmbArticuloTipo_Internalname = "ARTICULOTIPO_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         while ( nGXsfl_46_idx <= nRC_Grid1 )
         {
            sendrow_462( ) ;
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_46_idx ;
            edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_46_idx ;
            dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_46_idx ;
            cmbArticuloTipo_Internalname = "ARTICULOTIPO_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize46 ,
                                        String AV6cArticuloCodigo ,
                                        String AV7cArticuloDescripcion ,
                                        decimal AV8cArticuloPrecio ,
                                        decimal AV9cArticuloCosto ,
                                        String AV10cCategoriaCodigo ,
                                        String AV11cSubCategoriaCodigo ,
                                        String AV12pClinicaCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize46) ;
         RF2Q2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2Q2( ) ;
         /* End function Refresh */
      }

      protected void RF2Q2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 46 ;
         nGXsfl_46_idx = 1 ;
         sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_46_idx ;
         edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_46_idx ;
         dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_46_idx ;
         cmbArticuloTipo_Internalname = "ARTICULOTIPO_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_46_idx ;
            edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_46_idx ;
            dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_46_idx ;
            cmbArticuloTipo_Internalname = "ARTICULOTIPO_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            lV6cArticuloCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cArticuloCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cArticuloCodigo", AV6cArticuloCodigo);
            lV7cArticuloDescripcion = StringUtil.PadR( StringUtil.RTrim( AV7cArticuloDescripcion), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cArticuloDescripcion", AV7cArticuloDescripcion);
            lV10cCategoriaCodigo = StringUtil.PadR( StringUtil.RTrim( AV10cCategoriaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCategoriaCodigo", AV10cCategoriaCodigo);
            lV11cSubCategoriaCodigo = StringUtil.PadR( StringUtil.RTrim( AV11cSubCategoriaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cSubCategoriaCodigo", AV11cSubCategoriaCodigo);
            /* Using cursor H002Q4 */
            pr_default.execute(2, new Object[] {AV12pClinicaCodigo, lV6cArticuloCodigo, lV7cArticuloDescripcion, AV8cArticuloPrecio, AV9cArticuloCosto, lV10cCategoriaCodigo, lV11cSubCategoriaCodigo});
            nGXsfl_46_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A32ArticuloPrecio = H002Q4_A32ArticuloPrecio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
               A60ArticuloCosto = H002Q4_A60ArticuloCosto[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
               A124SubCategoriaCodigo = H002Q4_A124SubCategoriaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
               A41ClinicaCodigo = H002Q4_A41ClinicaCodigo[0] ;
               A33ArticuloTipo = H002Q4_A33ArticuloTipo[0] ;
               A27CategoriaCodigo = H002Q4_A27CategoriaCodigo[0] ;
               A31ArticuloDescripcion = H002Q4_A31ArticuloDescripcion[0] ;
               A30ArticuloCodigo = H002Q4_A30ArticuloCodigo[0] ;
               /* Execute user event: E122Q2 */
               E122Q2 ();
               pr_default.readNext(2);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0)) ;
            pr_default.close(2);
            wbEnd = 46 ;
            WB2Q0( ) ;
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
         lV6cArticuloCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cArticuloCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cArticuloCodigo", AV6cArticuloCodigo);
         lV7cArticuloDescripcion = StringUtil.PadR( StringUtil.RTrim( AV7cArticuloDescripcion), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cArticuloDescripcion", AV7cArticuloDescripcion);
         lV10cCategoriaCodigo = StringUtil.PadR( StringUtil.RTrim( AV10cCategoriaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCategoriaCodigo", AV10cCategoriaCodigo);
         lV11cSubCategoriaCodigo = StringUtil.PadR( StringUtil.RTrim( AV11cSubCategoriaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cSubCategoriaCodigo", AV11cSubCategoriaCodigo);
         /* Using cursor H002Q5 */
         pr_default.execute(3, new Object[] {AV12pClinicaCodigo, lV6cArticuloCodigo, lV7cArticuloDescripcion, AV8cArticuloPrecio, AV9cArticuloCosto, lV10cCategoriaCodigo, lV11cSubCategoriaCodigo});
         GRID1_nRecordCount = H002Q5_AGRID1_nRecordCount[0] ;
         pr_default.close(3);
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

      protected void STRUP2Q0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         GXVvCCATEGORIACODIGO_html2Q2( ) ;
         GXACATEGORIACODIGO_html2Q2( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112Q2 */
         E112Q2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cArticuloCodigo = cgiGet( edtavCarticulocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cArticuloCodigo", AV6cArticuloCodigo);
            AV7cArticuloDescripcion = cgiGet( edtavCarticulodescripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cArticuloDescripcion", AV7cArticuloDescripcion);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticuloprecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticuloprecio_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOPRECIO");
               GX_FocusControl = edtavCarticuloprecio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cArticuloPrecio = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cArticuloPrecio", StringUtil.LTrim( StringUtil.Str( AV8cArticuloPrecio, 17, 2)));
            }
            else
            {
               AV8cArticuloPrecio = context.localUtil.CToN( cgiGet( edtavCarticuloprecio_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cArticuloPrecio", StringUtil.LTrim( StringUtil.Str( AV8cArticuloPrecio, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulocosto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulocosto_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOCOSTO");
               GX_FocusControl = edtavCarticulocosto_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cArticuloCosto = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cArticuloCosto", StringUtil.LTrim( StringUtil.Str( AV9cArticuloCosto, 17, 2)));
            }
            else
            {
               AV9cArticuloCosto = context.localUtil.CToN( cgiGet( edtavCarticulocosto_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cArticuloCosto", StringUtil.LTrim( StringUtil.Str( AV9cArticuloCosto, 17, 2)));
            }
            dynavCcategoriacodigo.Name = dynavCcategoriacodigo_Internalname ;
            dynavCcategoriacodigo.CurrentValue = cgiGet( dynavCcategoriacodigo_Internalname) ;
            AV10cCategoriaCodigo = cgiGet( dynavCcategoriacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCategoriaCodigo", AV10cCategoriaCodigo);
            AV11cSubCategoriaCodigo = cgiGet( edtavCsubcategoriacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cSubCategoriaCodigo", AV11cSubCategoriaCodigo);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV12pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV13pArticuloCodigo = cgiGet( "vPARTICULOCODIGO") ;
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
         /* Execute user event: E112Q2 */
         E112Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112Q2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selecci�n %1", "Maestro de productos y servicios", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122Q2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_462( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132Q2 */
         E132Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132Q2( )
      {
         /* Enter Routine */
         AV13pArticuloCodigo = A30ArticuloCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pArticuloCodigo", AV13pArticuloCodigo);
         context.setWebReturnParms(new Object[] {(String)AV13pArticuloCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2Q2( bool wbgen )
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
            wb_table2_9_2Q2( true) ;
         }
         else
         {
            wb_table2_9_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2Q2e( bool wbgen )
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
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selecci�n"+"</legend>") ;
            wb_table3_43_2Q2( true) ;
         }
         else
         {
            wb_table3_43_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table3_43_2Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2Q2e( true) ;
         }
         else
         {
            wb_table1_2_2Q2e( false) ;
         }
      }

      protected void wb_table3_43_2Q2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"46\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Art�culo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Art�culo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Categor�a") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "C�digo") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A31ArticuloDescripcion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtArticuloDescripcion_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A27CategoriaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33ArticuloTipo), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 46 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_46_idx-1) ;
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
            wb_table4_55_2Q2( true) ;
         }
         else
         {
            wb_table4_55_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table4_55_2Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_2Q2e( true) ;
         }
         else
         {
            wb_table3_43_2Q2e( false) ;
         }
      }

      protected void wb_table4_55_2Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(46), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_55_2Q2e( true) ;
         }
         else
         {
            wb_table4_55_2Q2e( false) ;
         }
      }

      protected void wb_table2_9_2Q2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulocodigo_Internalname, "Art�culo", "", "", lblTextblockarticulocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cArticuloCodigo", AV6cArticuloCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCarticulocodigo_Internalname, StringUtil.RTrim( AV6cArticuloCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cArticuloCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCarticulocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulodescripcion_Internalname, "Art�culo", "", "", lblTextblockarticulodescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cArticuloDescripcion", AV7cArticuloDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCarticulodescripcion_Internalname, StringUtil.RTrim( AV7cArticuloDescripcion), StringUtil.RTrim( context.localUtil.Format( AV7cArticuloDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCarticulodescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloprecio_Internalname, "Precio", "", "", lblTextblockarticuloprecio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cArticuloPrecio", StringUtil.LTrim( StringUtil.Str( AV8cArticuloPrecio, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCarticuloprecio_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cArticuloPrecio, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cArticuloPrecio, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV8cArticuloPrecio, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCarticuloprecio_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulocosto_Internalname, "Costo", "", "", lblTextblockarticulocosto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cArticuloCosto", StringUtil.LTrim( StringUtil.Str( AV9cArticuloCosto, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCarticulocosto_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cArticuloCosto, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cArticuloCosto, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV9cArticuloCosto, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCarticulocosto_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcategoriacodigo_Internalname, "Categor�a", "", "", lblTextblockcategoriacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCategoriaCodigo", AV10cCategoriaCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavCcategoriacodigo, dynavCcategoriacodigo_Internalname, AV10cCategoriaCodigo, 1, dynavCcategoriacodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", true, "HLP_Gx00C1.htm");
            dynavCcategoriacodigo.CurrentValue = AV10cCategoriaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavCcategoriacodigo_Internalname, "Values", (String)(dynavCcategoriacodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksubcategoriacodigo_Internalname, "Sub_Categor�a", "", "", lblTextblocksubcategoriacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cSubCategoriaCodigo", AV11cSubCategoriaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsubcategoriacodigo_Internalname, StringUtil.RTrim( AV11cSubCategoriaCodigo), StringUtil.RTrim( context.localUtil.Format( AV11cSubCategoriaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", "", "", "", edtavCsubcategoriacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00C1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2Q2e( true) ;
         }
         else
         {
            wb_table2_9_2Q2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pArticuloCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pArticuloCodigo", AV13pArticuloCodigo);
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
         PA2Q2( ) ;
         WS2Q2( ) ;
         WE2Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?159385");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("gx00c1.js", "?159385");
         /* End function include_jscripts */
      }

      protected void sendrow_462( )
      {
         WB2Q0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_46_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_46_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_46_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A30ArticuloCodigo))+"'"+"]);" ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)AV5LinkSelection,(String)edtavLinkselection_Link,(String)"",(String)"",(String)"Fantastic",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtArticuloDescripcion_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A30ArticuloCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloDescripcion_Internalname,StringUtil.RTrim( A31ArticuloDescripcion),(String)"",(String)"",(String)"",(String)edtArticuloDescripcion_Link,(String)"",(String)"Seleccionar",(String)edtArticuloDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            GXACATEGORIACODIGO_html2Q2( ) ;
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CATEGORIACODIGO_" + sGXsfl_46_idx ;
               dynCategoriaCodigo.Name = GXCCtl ;
               dynCategoriaCodigo.WebTags = "" ;
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynCategoriaCodigo,(String)dynCategoriaCodigo_Internalname,(String)A27CategoriaCodigo,(short)1,(String)dynCategoriaCodigo_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            dynCategoriaCodigo.CurrentValue = A27CategoriaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynCategoriaCodigo_Internalname, "Values", (String)(dynCategoriaCodigo.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "ARTICULOTIPO_" + sGXsfl_46_idx ;
               cmbArticuloTipo.Name = GXCCtl ;
               cmbArticuloTipo.WebTags = "" ;
               cmbArticuloTipo.addItem("0", "Servicio", 0);
               cmbArticuloTipo.addItem("1", "Producto", 0);
               if ( ( cmbArticuloTipo.ItemCount > 0 ) && (0==A33ArticuloTipo) )
               {
                  A33ArticuloTipo = (short)(NumberUtil.Val( cmbArticuloTipo.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbArticuloTipo,(String)cmbArticuloTipo_Internalname,StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0),(short)1,(String)cmbArticuloTipo_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbArticuloTipo.CurrentValue = StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloTipo_Internalname, "Values", (String)(cmbArticuloTipo.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_46_idx ;
            edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_46_idx ;
            dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_46_idx ;
            cmbArticuloTipo_Internalname = "ARTICULOTIPO_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         }
         /* End function sendrow_462 */
      }

      protected void init_default_properties( )
      {
         lblTextblockarticulocodigo_Internalname = "TEXTBLOCKARTICULOCODIGO" ;
         edtavCarticulocodigo_Internalname = "vCARTICULOCODIGO" ;
         lblTextblockarticulodescripcion_Internalname = "TEXTBLOCKARTICULODESCRIPCION" ;
         edtavCarticulodescripcion_Internalname = "vCARTICULODESCRIPCION" ;
         lblTextblockarticuloprecio_Internalname = "TEXTBLOCKARTICULOPRECIO" ;
         edtavCarticuloprecio_Internalname = "vCARTICULOPRECIO" ;
         lblTextblockarticulocosto_Internalname = "TEXTBLOCKARTICULOCOSTO" ;
         edtavCarticulocosto_Internalname = "vCARTICULOCOSTO" ;
         lblTextblockcategoriacodigo_Internalname = "TEXTBLOCKCATEGORIACODIGO" ;
         dynavCcategoriacodigo_Internalname = "vCCATEGORIACODIGO" ;
         lblTextblocksubcategoriacodigo_Internalname = "TEXTBLOCKSUBCATEGORIACODIGO" ;
         edtavCsubcategoriacodigo_Internalname = "vCSUBCATEGORIACODIGO" ;
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
         edtClinicaCodigo_Jsonclick = "" ;
         cmbArticuloTipo_Jsonclick = "" ;
         dynCategoriaCodigo_Jsonclick = "" ;
         edtArticuloDescripcion_Jsonclick = "" ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtavCsubcategoriacodigo_Jsonclick = "" ;
         dynavCcategoriacodigo_Jsonclick = "" ;
         edtavCarticulocosto_Jsonclick = "" ;
         edtavCarticuloprecio_Jsonclick = "" ;
         edtavCarticulodescripcion_Jsonclick = "" ;
         edtavCarticulocodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtArticuloDescripcion_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Maestro de productos y servicios" ;
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
         wcpOAV12pClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         AV6cArticuloCodigo = "" ;
         AV7cArticuloDescripcion = "" ;
         AV10cCategoriaCodigo = "" ;
         AV11cSubCategoriaCodigo = "" ;
         AV13pArticuloCodigo = "" ;
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
         edtArticuloCodigo_Internalname = "" ;
         edtArticuloDescripcion_Internalname = "" ;
         dynCategoriaCodigo_Internalname = "" ;
         cmbArticuloTipo_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A30ArticuloCodigo = "" ;
         A31ArticuloDescripcion = "" ;
         A27CategoriaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H002Q2_A41ClinicaCodigo = new String[] {""} ;
         H002Q2_A27CategoriaCodigo = new String[] {""} ;
         H002Q2_A28CategoriaDescripcion = new String[] {""} ;
         H002Q2_A29CategoriaEstado = new short[1] ;
         H002Q3_A41ClinicaCodigo = new String[] {""} ;
         H002Q3_A27CategoriaCodigo = new String[] {""} ;
         H002Q3_A28CategoriaDescripcion = new String[] {""} ;
         H002Q3_A29CategoriaEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         lV6cArticuloCodigo = "" ;
         lV7cArticuloDescripcion = "" ;
         lV10cCategoriaCodigo = "" ;
         lV11cSubCategoriaCodigo = "" ;
         H002Q4_A32ArticuloPrecio = new decimal[1] ;
         H002Q4_A60ArticuloCosto = new decimal[1] ;
         H002Q4_A124SubCategoriaCodigo = new String[] {""} ;
         H002Q4_A41ClinicaCodigo = new String[] {""} ;
         H002Q4_A33ArticuloTipo = new short[1] ;
         H002Q4_A27CategoriaCodigo = new String[] {""} ;
         H002Q4_A31ArticuloDescripcion = new String[] {""} ;
         H002Q4_A30ArticuloCodigo = new String[] {""} ;
         A124SubCategoriaCodigo = "" ;
         H002Q5_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char5 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockarticulocodigo_Jsonclick = "" ;
         lblTextblockarticulodescripcion_Jsonclick = "" ;
         lblTextblockarticuloprecio_Jsonclick = "" ;
         lblTextblockarticulocosto_Jsonclick = "" ;
         lblTextblockcategoriacodigo_Jsonclick = "" ;
         lblTextblocksubcategoriacodigo_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char6 = "" ;
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00c1__default(),
            new Object[][] {
                new Object[] {
               H002Q2_A41ClinicaCodigo, H002Q2_A27CategoriaCodigo, H002Q2_A28CategoriaDescripcion, H002Q2_A29CategoriaEstado
               }
               , new Object[] {
               H002Q3_A41ClinicaCodigo, H002Q3_A27CategoriaCodigo, H002Q3_A28CategoriaDescripcion, H002Q3_A29CategoriaEstado
               }
               , new Object[] {
               H002Q4_A32ArticuloPrecio, H002Q4_A60ArticuloCosto, H002Q4_A124SubCategoriaCodigo, H002Q4_A41ClinicaCodigo, H002Q4_A33ArticuloTipo, H002Q4_A27CategoriaCodigo, H002Q4_A31ArticuloDescripcion, H002Q4_A30ArticuloCodigo
               }
               , new Object[] {
               H002Q5_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_46_idx=1 ;
      private short A33ArticuloTipo ;
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
      private int Grid1_PageSize46 ;
      private int GRID1_nFirstRecordOnPage ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV8cArticuloPrecio ;
      private decimal AV9cArticuloCosto ;
      private decimal A32ArticuloPrecio ;
      private decimal A60ArticuloCosto ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_46_idx="0001" ;
      private String GXCCtl ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtArticuloCodigo_Internalname ;
      private String edtArticuloDescripcion_Internalname ;
      private String dynCategoriaCodigo_Internalname ;
      private String cmbArticuloTipo_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtavCarticulocodigo_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCarticulodescripcion_Internalname ;
      private String edtavCarticuloprecio_Internalname ;
      private String edtavCarticulocosto_Internalname ;
      private String dynavCcategoriacodigo_Internalname ;
      private String edtavCsubcategoriacodigo_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtArticuloDescripcion_Link ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockarticulocodigo_Internalname ;
      private String lblTextblockarticulocodigo_Jsonclick ;
      private String edtavCarticulocodigo_Jsonclick ;
      private String lblTextblockarticulodescripcion_Internalname ;
      private String lblTextblockarticulodescripcion_Jsonclick ;
      private String edtavCarticulodescripcion_Jsonclick ;
      private String lblTextblockarticuloprecio_Internalname ;
      private String lblTextblockarticuloprecio_Jsonclick ;
      private String edtavCarticuloprecio_Jsonclick ;
      private String lblTextblockarticulocosto_Internalname ;
      private String lblTextblockarticulocosto_Jsonclick ;
      private String edtavCarticulocosto_Jsonclick ;
      private String lblTextblockcategoriacodigo_Internalname ;
      private String lblTextblockcategoriacodigo_Jsonclick ;
      private String dynavCcategoriacodigo_Jsonclick ;
      private String lblTextblocksubcategoriacodigo_Internalname ;
      private String lblTextblocksubcategoriacodigo_Jsonclick ;
      private String edtavCsubcategoriacodigo_Jsonclick ;
      private String GXt_char6 ;
      private String ROClassString ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtArticuloDescripcion_Jsonclick ;
      private String dynCategoriaCodigo_Jsonclick ;
      private String cmbArticuloTipo_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV12pClinicaCodigo ;
      private String wcpOAV12pClinicaCodigo ;
      private String AV6cArticuloCodigo ;
      private String AV7cArticuloDescripcion ;
      private String AV10cCategoriaCodigo ;
      private String AV11cSubCategoriaCodigo ;
      private String AV13pArticuloCodigo ;
      private String A30ArticuloCodigo ;
      private String A31ArticuloDescripcion ;
      private String A27CategoriaCodigo ;
      private String A41ClinicaCodigo ;
      private String lV6cArticuloCodigo ;
      private String lV7cArticuloDescripcion ;
      private String lV10cCategoriaCodigo ;
      private String lV11cSubCategoriaCodigo ;
      private String A124SubCategoriaCodigo ;
      private String AV5LinkSelection ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavCcategoriacodigo ;
      private GXCombobox dynCategoriaCodigo ;
      private GXCombobox cmbArticuloTipo ;
      private IDataStoreProvider pr_default ;
      private String[] H002Q2_A41ClinicaCodigo ;
      private String[] H002Q2_A27CategoriaCodigo ;
      private String[] H002Q2_A28CategoriaDescripcion ;
      private short[] H002Q2_A29CategoriaEstado ;
      private String[] H002Q3_A41ClinicaCodigo ;
      private String[] H002Q3_A27CategoriaCodigo ;
      private String[] H002Q3_A28CategoriaDescripcion ;
      private short[] H002Q3_A29CategoriaEstado ;
      private decimal[] H002Q4_A32ArticuloPrecio ;
      private decimal[] H002Q4_A60ArticuloCosto ;
      private String[] H002Q4_A124SubCategoriaCodigo ;
      private String[] H002Q4_A41ClinicaCodigo ;
      private short[] H002Q4_A33ArticuloTipo ;
      private String[] H002Q4_A27CategoriaCodigo ;
      private String[] H002Q4_A31ArticuloDescripcion ;
      private String[] H002Q4_A30ArticuloCodigo ;
      private int[] H002Q5_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP1_pArticuloCodigo ;
      private GXWebForm Form ;
   }

   public class gx00c1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002Q2 ;
          prmH002Q2 = new Object[] {
          } ;
          Object[] prmH002Q3 ;
          prmH002Q3 = new Object[] {
          } ;
          Object[] prmH002Q4 ;
          prmH002Q4 = new Object[] {
          new Object[] {"@AV12pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV6cArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cArticuloDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV8cArticuloPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV9cArticuloCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@lV10cCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV11cSubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH002Q5 ;
          prmH002Q5 = new Object[] {
          new Object[] {"@AV12pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV6cArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cArticuloDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV8cArticuloPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV9cArticuloCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@lV10cCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV11cSubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002Q2", "SELECT [ClinicaCodigo], [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado] FROM [Categoria] WITH (NOLOCK) WHERE [CategoriaEstado] = 1 ORDER BY [CategoriaDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q2,0,0,true,false )
             ,new CursorDef("H002Q3", "SELECT [ClinicaCodigo], [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado] FROM [Categoria] WITH (NOLOCK) WHERE [CategoriaEstado] = 1 ORDER BY [CategoriaDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q3,0,0,true,false )
             ,new CursorDef("H002Q4", "SELECT [ArticuloPrecio], [ArticuloCosto], [SubCategoriaCodigo], [ClinicaCodigo], [ArticuloTipo], [CategoriaCodigo], [ArticuloDescripcion], [ArticuloCodigo] FROM [Articulo] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV12pClinicaCodigo) AND ([ArticuloCodigo] like @lV6cArticuloCodigo) AND ([ArticuloDescripcion] like @lV7cArticuloDescripcion) AND ([ArticuloPrecio] >= @AV8cArticuloPrecio) AND ([ArticuloCosto] >= @AV9cArticuloCosto) AND ([CategoriaCodigo] like @lV10cCategoriaCodigo) AND ([SubCategoriaCodigo] like @lV11cSubCategoriaCodigo) ORDER BY [ClinicaCodigo], [ArticuloCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q4,11,0,true,false )
             ,new CursorDef("H002Q5", "SELECT COUNT(*) FROM [Articulo] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV12pClinicaCodigo) AND ([ArticuloCodigo] like @lV6cArticuloCodigo) AND ([ArticuloDescripcion] like @lV7cArticuloDescripcion) AND ([ArticuloPrecio] >= @AV8cArticuloPrecio) AND ([ArticuloCosto] >= @AV9cArticuloCosto) AND ([CategoriaCodigo] like @lV10cCategoriaCodigo) AND ([SubCategoriaCodigo] like @lV11cSubCategoriaCodigo) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q5,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
             case 3 :
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
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
