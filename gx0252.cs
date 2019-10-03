/*
               File: Gx0252
        Description: Selection List Tipo Rango
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:55.91
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
   public class gx0252 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0252( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx0252( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           int aP1_pTipoVendedorId ,
                           out int aP2_pTipoRangoId )
      {
         this.AV11pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV12pTipoVendedorId = aP1_pTipoVendedorId;
         this.AV13pTipoRangoId = 0 ;
         executePrivate();
         aP2_pTipoRangoId=this.AV13pTipoRangoId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynTipoVendedorId = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"TIPOVENDEDORID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLATIPOVENDEDORID3K2( ) ;
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
               nGXsfl_41_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_41_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_41_idx, sGXsfl_41_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               GXCCtl = "TIPOVENDEDORID_" + sGXsfl_41_idx ;
               dynTipoVendedorId.Name = GXCCtl ;
               dynTipoVendedorId.WebTags = "" ;
               Grid1_PageSize41 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cTipoRangoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTipoRangoId), 9, 0)));
               AV7cTipoRangoNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoRangoNombre", AV7cTipoRangoNombre);
               AV8cTipoRangoInicial = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoRangoInicial", StringUtil.LTrim( StringUtil.Str( AV8cTipoRangoInicial, 17, 2)));
               AV9cTipoRangoFinal = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoRangoFinal", StringUtil.LTrim( StringUtil.Str( AV9cTipoRangoFinal, 17, 2)));
               AV10cTipoRangoPorcentaje = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoRangoPorcentaje", StringUtil.LTrim( StringUtil.Str( AV10cTipoRangoPorcentaje, 17, 2)));
               AV11pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pClinicaCodigo", AV11pClinicaCodigo);
               AV12pTipoVendedorId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTipoVendedorId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize41, AV6cTipoRangoId, AV7cTipoRangoNombre, AV8cTipoRangoInicial, AV9cTipoRangoFinal, AV10cTipoRangoPorcentaje, AV11pClinicaCodigo, AV12pTipoVendedorId) ;
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
               AV11pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pClinicaCodigo", AV11pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12pTipoVendedorId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTipoVendedorId), 9, 0)));
                  AV13pTipoRangoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTipoRangoId), 9, 0)));
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
         PA3K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3K2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0252.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11pClinicaCodigo)) + "," + UrlEncode("" +AV12pTipoVendedorId) + "," + UrlEncode("" +AV13pTipoRangoId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPORANGOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTipoRangoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPORANGONOMBRE", StringUtil.RTrim( AV7cTipoRangoNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPORANGOINICIAL", StringUtil.LTrim( StringUtil.NToC( AV8cTipoRangoInicial, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPORANGOFINAL", StringUtil.LTrim( StringUtil.NToC( AV9cTipoRangoFinal, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPORANGOPORCENTAJE", StringUtil.LTrim( StringUtil.NToC( AV10cTipoRangoPorcentaje, 17, 2, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV11pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPTIPOVENDEDORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pTipoVendedorId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPTIPORANGOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pTipoRangoId), 9, 0, ".", "")));
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
            WE3K2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3K2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0252" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Tipo Rango" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0252.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11pClinicaCodigo)) + "," + UrlEncode("" +AV12pTipoVendedorId) + "," + UrlEncode("" +AV13pTipoRangoId) ;
      }

      protected void WB3K0( )
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
            wb_table1_2_3K2( true) ;
         }
         else
         {
            wb_table1_2_3K2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3K2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START3K2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Tipo Rango", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP3K0( ) ;
      }

      protected void WS3K2( )
      {
         START3K2( ) ;
         EVT3K2( ) ;
      }

      protected void EVT3K2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOID"), ".", ",") != Convert.ToDecimal( AV6cTipoRangoId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPORANGONOMBRE"), AV7cTipoRangoNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOINICIAL"), ".", ",") != AV8cTipoRangoInicial )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOFINAL"), ".", ",") != AV9cTipoRangoFinal )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOPORCENTAJE"), ".", ",") != AV10cTipoRangoPorcentaje )
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
                              nGXsfl_41_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
                              edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_41_idx ;
                              edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_41_idx ;
                              edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_41_idx ;
                              edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_41_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
                              dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_41_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A373TipoRangoId = (int)(context.localUtil.CToN( cgiGet( edtTipoRangoId_Internalname), ".", ",")) ;
                              A374TipoRangoNombre = cgiGet( edtTipoRangoNombre_Internalname) ;
                              A375TipoRangoInicial = context.localUtil.CToN( cgiGet( edtTipoRangoInicial_Internalname), ".", ",") ;
                              A376TipoRangoFinal = context.localUtil.CToN( cgiGet( edtTipoRangoFinal_Internalname), ".", ",") ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              dynTipoVendedorId.Name = dynTipoVendedorId_Internalname ;
                              dynTipoVendedorId.CurrentValue = cgiGet( dynTipoVendedorId_Internalname) ;
                              A370TipoVendedorId = (int)(NumberUtil.Val( cgiGet( dynTipoVendedorId_Internalname), ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E113K2 */
                                    E113K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E123K2 */
                                    E123K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ctiporangoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOID"), ".", ",") != Convert.ToDecimal( AV6cTipoRangoId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctiporangonombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPORANGONOMBRE"), AV7cTipoRangoNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctiporangoinicial Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOINICIAL"), ".", ",") != AV8cTipoRangoInicial )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctiporangofinal Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOFINAL"), ".", ",") != AV9cTipoRangoFinal )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctiporangoporcentaje Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCTIPORANGOPORCENTAJE"), ".", ",") != AV10cTipoRangoPorcentaje )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E133K2 */
                                          E133K2 ();
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

      protected void WE3K2( )
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

      protected void PA3K2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "TIPOVENDEDORID_" + sGXsfl_41_idx ;
            dynTipoVendedorId.Name = GXCCtl ;
            dynTipoVendedorId.WebTags = "" ;
            GX_FocusControl = edtavCtiporangoid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLATIPOVENDEDORID3K2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLATIPOVENDEDORID_data3K2( ) ;
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

      protected void GXATIPOVENDEDORID_html3K2( )
      {
         int gxdynajaxvalue ;
         GXDLATIPOVENDEDORID_data3K2( ) ;
         gxdynajaxindex = 1 ;
         dynTipoVendedorId.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynTipoVendedorId.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLATIPOVENDEDORID_data3K2( )
      {
         /* Using cursor H003K2 */
         pr_default.execute(0);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H003K2_A370TipoVendedorId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H003K2_A371TipoVendedorNombre[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_41_idx ,
                                       String sGXsfl_41_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_41_idx ;
         edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_41_idx ;
         edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_41_idx ;
         edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_41_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
         dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_41_idx ;
         while ( nGXsfl_41_idx <= nRC_Grid1 )
         {
            sendrow_412( ) ;
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_41_idx ;
            edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_41_idx ;
            edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_41_idx ;
            edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_41_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
            dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_41_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize41 ,
                                        int AV6cTipoRangoId ,
                                        String AV7cTipoRangoNombre ,
                                        decimal AV8cTipoRangoInicial ,
                                        decimal AV9cTipoRangoFinal ,
                                        decimal AV10cTipoRangoPorcentaje ,
                                        String AV11pClinicaCodigo ,
                                        int AV12pTipoVendedorId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize41) ;
         RF3K2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF3K2( ) ;
         /* End function Refresh */
      }

      protected void RF3K2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 41 ;
         nGXsfl_41_idx = 1 ;
         sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_41_idx ;
         edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_41_idx ;
         edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_41_idx ;
         edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_41_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
         dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_41_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_41_idx ;
            edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_41_idx ;
            edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_41_idx ;
            edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_41_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
            dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_41_idx ;
            lV7cTipoRangoNombre = StringUtil.PadR( StringUtil.RTrim( AV7cTipoRangoNombre), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoRangoNombre", AV7cTipoRangoNombre);
            /* Using cursor H003K3 */
            pr_default.execute(1, new Object[] {AV11pClinicaCodigo, AV12pTipoVendedorId, AV6cTipoRangoId, lV7cTipoRangoNombre, AV8cTipoRangoInicial, AV9cTipoRangoFinal, AV10cTipoRangoPorcentaje});
            nGXsfl_41_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A377TipoRangoPorcentaje = H003K3_A377TipoRangoPorcentaje[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377TipoRangoPorcentaje", StringUtil.LTrim( StringUtil.Str( A377TipoRangoPorcentaje, 17, 2)));
               A370TipoVendedorId = H003K3_A370TipoVendedorId[0] ;
               A41ClinicaCodigo = H003K3_A41ClinicaCodigo[0] ;
               A376TipoRangoFinal = H003K3_A376TipoRangoFinal[0] ;
               A375TipoRangoInicial = H003K3_A375TipoRangoInicial[0] ;
               A374TipoRangoNombre = H003K3_A374TipoRangoNombre[0] ;
               A373TipoRangoId = H003K3_A373TipoRangoId[0] ;
               /* Execute user event: E123K2 */
               E123K2 ();
               pr_default.readNext(1);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 41 ;
            WB3K0( ) ;
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
         lV7cTipoRangoNombre = StringUtil.PadR( StringUtil.RTrim( AV7cTipoRangoNombre), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoRangoNombre", AV7cTipoRangoNombre);
         /* Using cursor H003K4 */
         pr_default.execute(2, new Object[] {AV11pClinicaCodigo, AV12pTipoVendedorId, AV6cTipoRangoId, lV7cTipoRangoNombre, AV8cTipoRangoInicial, AV9cTipoRangoFinal, AV10cTipoRangoPorcentaje});
         GRID1_nRecordCount = H003K4_AGRID1_nRecordCount[0] ;
         pr_default.close(2);
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

      protected void STRUP3K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         GXATIPOVENDEDORID_html3K2( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E113K2 */
         E113K2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtiporangoid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtiporangoid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPORANGOID");
               GX_FocusControl = edtavCtiporangoid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cTipoRangoId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTipoRangoId), 9, 0)));
            }
            else
            {
               AV6cTipoRangoId = (int)(context.localUtil.CToN( cgiGet( edtavCtiporangoid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTipoRangoId), 9, 0)));
            }
            AV7cTipoRangoNombre = cgiGet( edtavCtiporangonombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoRangoNombre", AV7cTipoRangoNombre);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtiporangoinicial_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtiporangoinicial_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPORANGOINICIAL");
               GX_FocusControl = edtavCtiporangoinicial_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cTipoRangoInicial = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoRangoInicial", StringUtil.LTrim( StringUtil.Str( AV8cTipoRangoInicial, 17, 2)));
            }
            else
            {
               AV8cTipoRangoInicial = context.localUtil.CToN( cgiGet( edtavCtiporangoinicial_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoRangoInicial", StringUtil.LTrim( StringUtil.Str( AV8cTipoRangoInicial, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtiporangofinal_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtiporangofinal_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPORANGOFINAL");
               GX_FocusControl = edtavCtiporangofinal_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cTipoRangoFinal = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoRangoFinal", StringUtil.LTrim( StringUtil.Str( AV9cTipoRangoFinal, 17, 2)));
            }
            else
            {
               AV9cTipoRangoFinal = context.localUtil.CToN( cgiGet( edtavCtiporangofinal_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoRangoFinal", StringUtil.LTrim( StringUtil.Str( AV9cTipoRangoFinal, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtiporangoporcentaje_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtiporangoporcentaje_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPORANGOPORCENTAJE");
               GX_FocusControl = edtavCtiporangoporcentaje_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cTipoRangoPorcentaje = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoRangoPorcentaje", StringUtil.LTrim( StringUtil.Str( AV10cTipoRangoPorcentaje, 17, 2)));
            }
            else
            {
               AV10cTipoRangoPorcentaje = context.localUtil.CToN( cgiGet( edtavCtiporangoporcentaje_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoRangoPorcentaje", StringUtil.LTrim( StringUtil.Str( AV10cTipoRangoPorcentaje, 17, 2)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV11pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV12pTipoVendedorId = (int)(context.localUtil.CToN( cgiGet( "vPTIPOVENDEDORID"), ".", ",")) ;
            AV13pTipoRangoId = (int)(context.localUtil.CToN( cgiGet( "vPTIPORANGOID"), ".", ",")) ;
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
         /* Execute user event: E113K2 */
         E113K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113K2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Tipo Rango", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E123K2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_412( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E133K2 */
         E133K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E133K2( )
      {
         /* Enter Routine */
         AV13pTipoRangoId = A373TipoRangoId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTipoRangoId), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pTipoRangoId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_3K2( bool wbgen )
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
            wb_table2_9_3K2( true) ;
         }
         else
         {
            wb_table2_9_3K2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_3K2e( bool wbgen )
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
            wb_table3_38_3K2( true) ;
         }
         else
         {
            wb_table3_38_3K2( false) ;
         }
         return  ;
      }

      protected void wb_table3_38_3K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3K2e( true) ;
         }
         else
         {
            wb_table1_2_3K2e( false) ;
         }
      }

      protected void wb_table3_38_3K2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"41\">") ;
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
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Inicial") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Final") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Tipo_Vendedor") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A374TipoRangoNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTipoRangoNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A375TipoRangoInicial, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A376TipoRangoFinal, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A370TipoVendedorId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 41 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_41_idx-1) ;
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
            wb_table4_51_3K2( true) ;
         }
         else
         {
            wb_table4_51_3K2( false) ;
         }
         return  ;
      }

      protected void wb_table4_51_3K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_38_3K2e( true) ;
         }
         else
         {
            wb_table3_38_3K2e( false) ;
         }
      }

      protected void wb_table4_51_3K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(41), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_51_3K2e( true) ;
         }
         else
         {
            wb_table4_51_3K2e( false) ;
         }
      }

      protected void wb_table2_9_3K2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblocktiporangoid_Internalname, "Id", "", "", lblTextblocktiporangoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTipoRangoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtiporangoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTipoRangoId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cTipoRangoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cTipoRangoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavCtiporangoid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktiporangonombre_Internalname, "Descripción", "", "", lblTextblocktiporangonombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoRangoNombre", AV7cTipoRangoNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtiporangonombre_Internalname, StringUtil.RTrim( AV7cTipoRangoNombre), StringUtil.RTrim( context.localUtil.Format( AV7cTipoRangoNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCtiporangonombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktiporangoinicial_Internalname, "Inicial", "", "", lblTextblocktiporangoinicial_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoRangoInicial", StringUtil.LTrim( StringUtil.Str( AV8cTipoRangoInicial, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtiporangoinicial_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cTipoRangoInicial, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cTipoRangoInicial, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV8cTipoRangoInicial, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCtiporangoinicial_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktiporangofinal_Internalname, "Final", "", "", lblTextblocktiporangofinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoRangoFinal", StringUtil.LTrim( StringUtil.Str( AV9cTipoRangoFinal, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtiporangofinal_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cTipoRangoFinal, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cTipoRangoFinal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV9cTipoRangoFinal, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCtiporangofinal_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktiporangoporcentaje_Internalname, "Porcentaje", "", "", lblTextblocktiporangoporcentaje_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoRangoPorcentaje", StringUtil.LTrim( StringUtil.Str( AV10cTipoRangoPorcentaje, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtiporangoporcentaje_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cTipoRangoPorcentaje, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10cTipoRangoPorcentaje, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV10cTipoRangoPorcentaje, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(34);\"", "", "", "", "", edtavCtiporangoporcentaje_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx0252.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_3K2e( true) ;
         }
         else
         {
            wb_table2_9_3K2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pClinicaCodigo", AV11pClinicaCodigo);
         AV12pTipoVendedorId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTipoVendedorId), 9, 0)));
         AV13pTipoRangoId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoRangoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTipoRangoId), 9, 0)));
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
         PA3K2( ) ;
         WS3K2( ) ;
         WE3K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1595662");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("gx0252.js", "?1595662");
         /* End function include_jscripts */
      }

      protected void sendrow_412( )
      {
         WB3K0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_41_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_41_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_41_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A373TipoRangoId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTipoRangoNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoNombre_Internalname,StringUtil.RTrim( A374TipoRangoNombre),(String)"",(String)"",(String)"",(String)edtTipoRangoNombre_Link,(String)"",(String)"Seleccionar",(String)edtTipoRangoNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoInicial_Internalname,StringUtil.LTrim( StringUtil.NToC( A375TipoRangoInicial, 17, 2, ".", "")),context.localUtil.Format( A375TipoRangoInicial, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoInicial_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoFinal_Internalname,StringUtil.LTrim( StringUtil.NToC( A376TipoRangoFinal, 17, 2, ".", "")),context.localUtil.Format( A376TipoRangoFinal, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoFinal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            GXATIPOVENDEDORID_html3K2( ) ;
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_41_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOVENDEDORID_" + sGXsfl_41_idx ;
               dynTipoVendedorId.Name = GXCCtl ;
               dynTipoVendedorId.WebTags = "" ;
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynTipoVendedorId,(String)dynTipoVendedorId_Internalname,StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0),(short)1,(String)dynTipoVendedorId_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            dynTipoVendedorId.CurrentValue = StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoVendedorId_Internalname, "Values", (String)(dynTipoVendedorId.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_41_idx ;
            edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_41_idx ;
            edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_41_idx ;
            edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_41_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
            dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_41_idx ;
         }
         /* End function sendrow_412 */
      }

      protected void init_default_properties( )
      {
         lblTextblocktiporangoid_Internalname = "TEXTBLOCKTIPORANGOID" ;
         edtavCtiporangoid_Internalname = "vCTIPORANGOID" ;
         lblTextblocktiporangonombre_Internalname = "TEXTBLOCKTIPORANGONOMBRE" ;
         edtavCtiporangonombre_Internalname = "vCTIPORANGONOMBRE" ;
         lblTextblocktiporangoinicial_Internalname = "TEXTBLOCKTIPORANGOINICIAL" ;
         edtavCtiporangoinicial_Internalname = "vCTIPORANGOINICIAL" ;
         lblTextblocktiporangofinal_Internalname = "TEXTBLOCKTIPORANGOFINAL" ;
         edtavCtiporangofinal_Internalname = "vCTIPORANGOFINAL" ;
         lblTextblocktiporangoporcentaje_Internalname = "TEXTBLOCKTIPORANGOPORCENTAJE" ;
         edtavCtiporangoporcentaje_Internalname = "vCTIPORANGOPORCENTAJE" ;
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
         dynTipoVendedorId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtTipoRangoFinal_Jsonclick = "" ;
         edtTipoRangoInicial_Jsonclick = "" ;
         edtTipoRangoNombre_Jsonclick = "" ;
         edtTipoRangoId_Jsonclick = "" ;
         edtavCtiporangoporcentaje_Jsonclick = "" ;
         edtavCtiporangofinal_Jsonclick = "" ;
         edtavCtiporangoinicial_Jsonclick = "" ;
         edtavCtiporangonombre_Jsonclick = "" ;
         edtavCtiporangoid_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtTipoRangoNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Tipo Rango" ;
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
         wcpOAV11pClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         AV7cTipoRangoNombre = "" ;
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
         edtTipoRangoId_Internalname = "" ;
         edtTipoRangoNombre_Internalname = "" ;
         edtTipoRangoInicial_Internalname = "" ;
         edtTipoRangoFinal_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         dynTipoVendedorId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A374TipoRangoNombre = "" ;
         A41ClinicaCodigo = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H003K2_A41ClinicaCodigo = new String[] {""} ;
         H003K2_A370TipoVendedorId = new int[1] ;
         H003K2_A371TipoVendedorNombre = new String[] {""} ;
         H003K2_A372TipoVendedorEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         lV7cTipoRangoNombre = "" ;
         H003K3_A377TipoRangoPorcentaje = new decimal[1] ;
         H003K3_A370TipoVendedorId = new int[1] ;
         H003K3_A41ClinicaCodigo = new String[] {""} ;
         H003K3_A376TipoRangoFinal = new decimal[1] ;
         H003K3_A375TipoRangoInicial = new decimal[1] ;
         H003K3_A374TipoRangoNombre = new String[] {""} ;
         H003K3_A373TipoRangoId = new int[1] ;
         H003K4_AGRID1_nRecordCount = new int[1] ;
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
         lblTextblocktiporangoid_Jsonclick = "" ;
         lblTextblocktiporangonombre_Jsonclick = "" ;
         lblTextblocktiporangoinicial_Jsonclick = "" ;
         lblTextblocktiporangofinal_Jsonclick = "" ;
         lblTextblocktiporangoporcentaje_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0252__default(),
            new Object[][] {
                new Object[] {
               H003K2_A41ClinicaCodigo, H003K2_A370TipoVendedorId, H003K2_A371TipoVendedorNombre, H003K2_A372TipoVendedorEstado
               }
               , new Object[] {
               H003K3_A377TipoRangoPorcentaje, H003K3_A370TipoVendedorId, H003K3_A41ClinicaCodigo, H003K3_A376TipoRangoFinal, H003K3_A375TipoRangoInicial, H003K3_A374TipoRangoNombre, H003K3_A373TipoRangoId
               }
               , new Object[] {
               H003K4_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_41_idx=1 ;
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
      private int AV12pTipoVendedorId ;
      private int wcpOAV12pTipoVendedorId ;
      private int Grid1_PageSize41 ;
      private int AV6cTipoRangoId ;
      private int AV13pTipoRangoId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A373TipoRangoId ;
      private int A370TipoVendedorId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV8cTipoRangoInicial ;
      private decimal AV9cTipoRangoFinal ;
      private decimal AV10cTipoRangoPorcentaje ;
      private decimal A375TipoRangoInicial ;
      private decimal A376TipoRangoFinal ;
      private decimal A377TipoRangoPorcentaje ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_41_idx="0001" ;
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
      private String edtTipoRangoId_Internalname ;
      private String edtTipoRangoNombre_Internalname ;
      private String edtTipoRangoInicial_Internalname ;
      private String edtTipoRangoFinal_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String dynTipoVendedorId_Internalname ;
      private String edtavCtiporangoid_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCtiporangonombre_Internalname ;
      private String edtavCtiporangoinicial_Internalname ;
      private String edtavCtiporangofinal_Internalname ;
      private String edtavCtiporangoporcentaje_Internalname ;
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
      private String edtTipoRangoNombre_Link ;
      private String GXt_char6 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblocktiporangoid_Internalname ;
      private String lblTextblocktiporangoid_Jsonclick ;
      private String edtavCtiporangoid_Jsonclick ;
      private String lblTextblocktiporangonombre_Internalname ;
      private String lblTextblocktiporangonombre_Jsonclick ;
      private String edtavCtiporangonombre_Jsonclick ;
      private String lblTextblocktiporangoinicial_Internalname ;
      private String lblTextblocktiporangoinicial_Jsonclick ;
      private String edtavCtiporangoinicial_Jsonclick ;
      private String lblTextblocktiporangofinal_Internalname ;
      private String lblTextblocktiporangofinal_Jsonclick ;
      private String edtavCtiporangofinal_Jsonclick ;
      private String lblTextblocktiporangoporcentaje_Internalname ;
      private String lblTextblocktiporangoporcentaje_Jsonclick ;
      private String edtavCtiporangoporcentaje_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtTipoRangoId_Jsonclick ;
      private String edtTipoRangoNombre_Jsonclick ;
      private String edtTipoRangoInicial_Jsonclick ;
      private String edtTipoRangoFinal_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String dynTipoVendedorId_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV11pClinicaCodigo ;
      private String wcpOAV11pClinicaCodigo ;
      private String AV7cTipoRangoNombre ;
      private String A374TipoRangoNombre ;
      private String A41ClinicaCodigo ;
      private String lV7cTipoRangoNombre ;
      private String AV5LinkSelection ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynTipoVendedorId ;
      private IDataStoreProvider pr_default ;
      private String[] H003K2_A41ClinicaCodigo ;
      private int[] H003K2_A370TipoVendedorId ;
      private String[] H003K2_A371TipoVendedorNombre ;
      private short[] H003K2_A372TipoVendedorEstado ;
      private decimal[] H003K3_A377TipoRangoPorcentaje ;
      private int[] H003K3_A370TipoVendedorId ;
      private String[] H003K3_A41ClinicaCodigo ;
      private decimal[] H003K3_A376TipoRangoFinal ;
      private decimal[] H003K3_A375TipoRangoInicial ;
      private String[] H003K3_A374TipoRangoNombre ;
      private int[] H003K3_A373TipoRangoId ;
      private int[] H003K4_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP2_pTipoRangoId ;
      private GXWebForm Form ;
   }

   public class gx0252__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003K2 ;
          prmH003K2 = new Object[] {
          } ;
          Object[] prmH003K3 ;
          prmH003K3 = new Object[] {
          new Object[] {"@AV11pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12pTipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cTipoRangoId",SqlDbType.Int,9,0} ,
          new Object[] {"@lV7cTipoRangoNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV8cTipoRangoInicial",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV9cTipoRangoFinal",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV10cTipoRangoPorcentaje",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmH003K4 ;
          prmH003K4 = new Object[] {
          new Object[] {"@AV11pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12pTipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cTipoRangoId",SqlDbType.Int,9,0} ,
          new Object[] {"@lV7cTipoRangoNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV8cTipoRangoInicial",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV9cTipoRangoFinal",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV10cTipoRangoPorcentaje",SqlDbType.Decimal,17,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003K2", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEstado] FROM [TipoVendedor] WITH (NOLOCK) WHERE [TipoVendedorEstado] = 1 ORDER BY [TipoVendedorNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003K2,0,0,true,false )
             ,new CursorDef("H003K3", "SELECT [TipoRangoPorcentaje], [TipoVendedorId], [ClinicaCodigo], [TipoRangoFinal], [TipoRangoInicial], [TipoRangoNombre], [TipoRangoId] FROM [TipoVendedorRango] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV11pClinicaCodigo and [TipoVendedorId] = @AV12pTipoVendedorId and [TipoRangoId] >= @AV6cTipoRangoId) AND ([TipoRangoNombre] like @lV7cTipoRangoNombre) AND ([TipoRangoInicial] >= @AV8cTipoRangoInicial) AND ([TipoRangoFinal] >= @AV9cTipoRangoFinal) AND ([TipoRangoPorcentaje] >= @AV10cTipoRangoPorcentaje) ORDER BY [ClinicaCodigo], [TipoVendedorId], [TipoRangoId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003K3,11,0,true,false )
             ,new CursorDef("H003K4", "SELECT COUNT(*) FROM [TipoVendedorRango] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV11pClinicaCodigo and [TipoVendedorId] = @AV12pTipoVendedorId and [TipoRangoId] >= @AV6cTipoRangoId) AND ([TipoRangoNombre] like @lV7cTipoRangoNombre) AND ([TipoRangoInicial] >= @AV8cTipoRangoInicial) AND ([TipoRangoFinal] >= @AV9cTipoRangoFinal) AND ([TipoRangoPorcentaje] >= @AV10cTipoRangoPorcentaje) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003K4,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 2 :
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
       }
    }

 }

}
