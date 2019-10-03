/*
               File: Gx01I3
        Description: Selection List Detalle de partida contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:27.74
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
   public class gx01i3 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01i3( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01i3( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           String aP1_pTipoParCodigo ,
                           int aP2_pPartidaId ,
                           out short aP3_pPartidaLinea )
      {
         this.AV10pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV11pTipoParCodigo = aP1_pTipoParCodigo;
         this.AV12pPartidaId = aP2_pPartidaId;
         this.AV13pPartidaLinea = 0 ;
         executePrivate();
         aP3_pPartidaLinea=this.AV13pPartidaLinea;
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
               AV6cPartidaLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPartidaLinea), 4, 0)));
               AV7cPartidaDebe = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPartidaDebe", StringUtil.LTrim( StringUtil.Str( AV7cPartidaDebe, 17, 2)));
               AV8cPartidaHaber = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPartidaHaber", StringUtil.LTrim( StringUtil.Str( AV8cPartidaHaber, 17, 2)));
               AV9cCtaContableCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
               AV10pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
               AV11pTipoParCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pTipoParCodigo", AV11pTipoParCodigo);
               AV12pPartidaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPartidaId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV6cPartidaLinea, AV7cPartidaDebe, AV8cPartidaHaber, AV9cCtaContableCodigo, AV10pClinicaCodigo, AV11pTipoParCodigo, AV12pPartidaId) ;
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
                  AV11pTipoParCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pTipoParCodigo", AV11pTipoParCodigo);
                  AV12pPartidaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPartidaId), 9, 0)));
                  AV13pPartidaLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPartidaLinea), 4, 0)));
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
         PA202( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START202( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01i3.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV11pTipoParCodigo)) + "," + UrlEncode("" +AV12pPartidaId) + "," + UrlEncode("" +AV13pPartidaLinea)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCPARTIDALINEA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPartidaLinea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPARTIDADEBE", StringUtil.LTrim( StringUtil.NToC( AV7cPartidaDebe, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPARTIDAHABER", StringUtil.LTrim( StringUtil.NToC( AV8cPartidaHaber, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLECODIGO", StringUtil.RTrim( AV9cCtaContableCodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV10pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPTIPOPARCODIGO", StringUtil.RTrim( AV11pTipoParCodigo));
         GxWebStd.gx_hidden_field( context, "vPPARTIDAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pPartidaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPPARTIDALINEA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pPartidaLinea), 4, 0, ".", "")));
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
            WE202( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT202( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01I3" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Detalle de partida contable" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01i3.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV11pTipoParCodigo)) + "," + UrlEncode("" +AV12pPartidaId) + "," + UrlEncode("" +AV13pPartidaLinea) ;
      }

      protected void WB200( )
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
            wb_table1_2_202( true) ;
         }
         else
         {
            wb_table1_2_202( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_202e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START202( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Detalle de partida contable", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP200( ) ;
      }

      protected void WS202( )
      {
         START202( ) ;
         EVT202( ) ;
      }

      protected void EVT202( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARTIDALINEA"), ".", ",") != Convert.ToDecimal( AV6cPartidaLinea )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCPARTIDADEBE"), ".", ",") != AV7cPartidaDebe )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCPARTIDAHABER"), ".", ",") != AV8cPartidaHaber )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLECODIGO"), AV9cCtaContableCodigo) != 0 )
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
                              edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_36_idx ;
                              edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_36_idx ;
                              edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_36_idx ;
                              edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_36_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
                              edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_36_idx ;
                              edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_36_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A214PartidaLinea = (short)(context.localUtil.CToN( cgiGet( edtPartidaLinea_Internalname), ".", ",")) ;
                              A215PartidaDebe = context.localUtil.CToN( cgiGet( edtPartidaDebe_Internalname), ".", ",") ;
                              A216PartidaHaber = context.localUtil.CToN( cgiGet( edtPartidaHaber_Internalname), ".", ",") ;
                              A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
                              A207PartidaId = (int)(context.localUtil.CToN( cgiGet( edtPartidaId_Internalname), ".", ",")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11202 */
                                    E11202 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12202 */
                                    E12202 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cpartidalinea Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARTIDALINEA"), ".", ",") != Convert.ToDecimal( AV6cPartidaLinea )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cpartidadebe Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPARTIDADEBE"), ".", ",") != AV7cPartidaDebe )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cpartidahaber Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPARTIDAHABER"), ".", ",") != AV8cPartidaHaber )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontablecodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLECODIGO"), AV9cCtaContableCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13202 */
                                          E13202 ();
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

      protected void WE202( )
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

      protected void PA202( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCpartidalinea_Internalname ;
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
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_36_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_36_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_36_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_36_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_36_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_36_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_36_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_36_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_36_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        short AV6cPartidaLinea ,
                                        decimal AV7cPartidaDebe ,
                                        decimal AV8cPartidaHaber ,
                                        String AV9cCtaContableCodigo ,
                                        String AV10pClinicaCodigo ,
                                        String AV11pTipoParCodigo ,
                                        int AV12pPartidaId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF202( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF202( ) ;
         /* End function Refresh */
      }

      protected void RF202( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_36_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_36_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_36_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_36_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_36_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_36_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_36_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_36_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_36_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_36_idx ;
            lV9cCtaContableCodigo = StringUtil.PadR( StringUtil.RTrim( AV9cCtaContableCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
            /* Using cursor H00202 */
            pr_default.execute(0, new Object[] {AV10pClinicaCodigo, AV11pTipoParCodigo, AV12pPartidaId, AV6cPartidaLinea, AV7cPartidaDebe, AV8cPartidaHaber, lV9cCtaContableCodigo});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A207PartidaId = H00202_A207PartidaId[0] ;
               A199TipoParCodigo = H00202_A199TipoParCodigo[0] ;
               A41ClinicaCodigo = H00202_A41ClinicaCodigo[0] ;
               A193CtaContableCodigo = H00202_A193CtaContableCodigo[0] ;
               A216PartidaHaber = H00202_A216PartidaHaber[0] ;
               A215PartidaDebe = H00202_A215PartidaDebe[0] ;
               A214PartidaLinea = H00202_A214PartidaLinea[0] ;
               /* Execute user event: E12202 */
               E12202 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 36 ;
            WB200( ) ;
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
         lV9cCtaContableCodigo = StringUtil.PadR( StringUtil.RTrim( AV9cCtaContableCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
         /* Using cursor H00203 */
         pr_default.execute(1, new Object[] {AV10pClinicaCodigo, AV11pTipoParCodigo, AV12pPartidaId, AV6cPartidaLinea, AV7cPartidaDebe, AV8cPartidaHaber, lV9cCtaContableCodigo});
         GRID1_nRecordCount = H00203_AGRID1_nRecordCount[0] ;
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

      protected void STRUP200( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11202 */
         E11202 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpartidalinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpartidalinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPARTIDALINEA");
               GX_FocusControl = edtavCpartidalinea_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cPartidaLinea = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPartidaLinea), 4, 0)));
            }
            else
            {
               AV6cPartidaLinea = (short)(context.localUtil.CToN( cgiGet( edtavCpartidalinea_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPartidaLinea), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpartidadebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpartidadebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPARTIDADEBE");
               GX_FocusControl = edtavCpartidadebe_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cPartidaDebe = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPartidaDebe", StringUtil.LTrim( StringUtil.Str( AV7cPartidaDebe, 17, 2)));
            }
            else
            {
               AV7cPartidaDebe = context.localUtil.CToN( cgiGet( edtavCpartidadebe_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPartidaDebe", StringUtil.LTrim( StringUtil.Str( AV7cPartidaDebe, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpartidahaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpartidahaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPARTIDAHABER");
               GX_FocusControl = edtavCpartidahaber_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cPartidaHaber = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPartidaHaber", StringUtil.LTrim( StringUtil.Str( AV8cPartidaHaber, 17, 2)));
            }
            else
            {
               AV8cPartidaHaber = context.localUtil.CToN( cgiGet( edtavCpartidahaber_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPartidaHaber", StringUtil.LTrim( StringUtil.Str( AV8cPartidaHaber, 17, 2)));
            }
            AV9cCtaContableCodigo = cgiGet( edtavCctacontablecodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV10pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV11pTipoParCodigo = cgiGet( "vPTIPOPARCODIGO") ;
            AV12pPartidaId = (int)(context.localUtil.CToN( cgiGet( "vPPARTIDAID"), ".", ",")) ;
            AV13pPartidaLinea = (short)(context.localUtil.CToN( cgiGet( "vPPARTIDALINEA"), ".", ",")) ;
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
         /* Execute user event: E11202 */
         E11202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11202( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Detalle de partida contable", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12202( )
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
         /* Execute user event: E13202 */
         E13202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13202( )
      {
         /* Enter Routine */
         AV13pPartidaLinea = A214PartidaLinea ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPartidaLinea), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pPartidaLinea});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_202( bool wbgen )
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
            wb_table2_9_202( true) ;
         }
         else
         {
            wb_table2_9_202( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_202e( bool wbgen )
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
            wb_table3_33_202( true) ;
         }
         else
         {
            wb_table3_33_202( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_202e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_202e( true) ;
         }
         else
         {
            wb_table1_2_202e( false) ;
         }
      }

      protected void wb_table3_33_202( bool wbgen )
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
               context.SendWebValue( "Debe") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Haber") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cta_Contable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Tipo_Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Partida") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtPartidaDebe_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A193CtaContableCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A199TipoParCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")));
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
            wb_table4_47_202( true) ;
         }
         else
         {
            wb_table4_47_202( false) ;
         }
         return  ;
      }

      protected void wb_table4_47_202e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_202e( true) ;
         }
         else
         {
            wb_table3_33_202e( false) ;
         }
      }

      protected void wb_table4_47_202( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_47_202e( true) ;
         }
         else
         {
            wb_table4_47_202e( false) ;
         }
      }

      protected void wb_table2_9_202( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidalinea_Internalname, "Línea", "", "", lblTextblockpartidalinea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPartidaLinea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCpartidalinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPartidaLinea), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cPartidaLinea), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cPartidaLinea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavCpartidalinea_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidadebe_Internalname, "Debe", "", "", lblTextblockpartidadebe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPartidaDebe", StringUtil.LTrim( StringUtil.Str( AV7cPartidaDebe, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCpartidadebe_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7cPartidaDebe, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7cPartidaDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV7cPartidaDebe, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCpartidadebe_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpartidahaber_Internalname, "Haber", "", "", lblTextblockpartidahaber_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPartidaHaber", StringUtil.LTrim( StringUtil.Str( AV8cPartidaHaber, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCpartidahaber_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cPartidaHaber, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cPartidaHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV8cPartidaHaber, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCpartidahaber_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Cta_Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCctacontablecodigo_Internalname, StringUtil.RTrim( AV9cCtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( AV9cCtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavCctacontablecodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01I3.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_202e( true) ;
         }
         else
         {
            wb_table2_9_202e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
         AV11pTipoParCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pTipoParCodigo", AV11pTipoParCodigo);
         AV12pPartidaId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPartidaId), 9, 0)));
         AV13pPartidaLinea = Convert.ToInt16(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPartidaLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPartidaLinea), 4, 0)));
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
         PA202( ) ;
         WS202( ) ;
         WE202( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1592834");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("gx01i3.js", "?1592834");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB200( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A214PartidaLinea), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtPartidaDebe_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaDebe_Internalname,StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", "")),context.localUtil.Format( A215PartidaDebe, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)edtPartidaDebe_Link,(String)"",(String)"Seleccionar",(String)edtPartidaDebe_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaHaber_Internalname,StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", "")),context.localUtil.Format( A216PartidaHaber, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaHaber_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableCodigo_Internalname,StringUtil.RTrim( A193CtaContableCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCtaContableCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParCodigo_Internalname,StringUtil.RTrim( A199TipoParCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A207PartidaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_36_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_36_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_36_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_36_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblockpartidalinea_Internalname = "TEXTBLOCKPARTIDALINEA" ;
         edtavCpartidalinea_Internalname = "vCPARTIDALINEA" ;
         lblTextblockpartidadebe_Internalname = "TEXTBLOCKPARTIDADEBE" ;
         edtavCpartidadebe_Internalname = "vCPARTIDADEBE" ;
         lblTextblockpartidahaber_Internalname = "TEXTBLOCKPARTIDAHABER" ;
         edtavCpartidahaber_Internalname = "vCPARTIDAHABER" ;
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtavCctacontablecodigo_Internalname = "vCCTACONTABLECODIGO" ;
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
         edtPartidaId_Jsonclick = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtPartidaHaber_Jsonclick = "" ;
         edtPartidaDebe_Jsonclick = "" ;
         edtPartidaLinea_Jsonclick = "" ;
         edtavCctacontablecodigo_Jsonclick = "" ;
         edtavCpartidahaber_Jsonclick = "" ;
         edtavCpartidadebe_Jsonclick = "" ;
         edtavCpartidalinea_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtPartidaDebe_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Detalle de partida contable" ;
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
         wcpOAV11pTipoParCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV9cCtaContableCodigo = "" ;
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
         edtPartidaLinea_Internalname = "" ;
         edtPartidaDebe_Internalname = "" ;
         edtPartidaHaber_Internalname = "" ;
         edtCtaContableCodigo_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtTipoParCodigo_Internalname = "" ;
         edtPartidaId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A193CtaContableCodigo = "" ;
         A41ClinicaCodigo = "" ;
         A199TipoParCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV9cCtaContableCodigo = "" ;
         H00202_A207PartidaId = new int[1] ;
         H00202_A199TipoParCodigo = new String[] {""} ;
         H00202_A41ClinicaCodigo = new String[] {""} ;
         H00202_A193CtaContableCodigo = new String[] {""} ;
         H00202_A216PartidaHaber = new decimal[1] ;
         H00202_A215PartidaDebe = new decimal[1] ;
         H00202_A214PartidaLinea = new short[1] ;
         H00203_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char7 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockpartidalinea_Jsonclick = "" ;
         lblTextblockpartidadebe_Jsonclick = "" ;
         lblTextblockpartidahaber_Jsonclick = "" ;
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01i3__default(),
            new Object[][] {
                new Object[] {
               H00202_A207PartidaId, H00202_A199TipoParCodigo, H00202_A41ClinicaCodigo, H00202_A193CtaContableCodigo, H00202_A216PartidaHaber, H00202_A215PartidaDebe, H00202_A214PartidaLinea
               }
               , new Object[] {
               H00203_AGRID1_nRecordCount
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
      private short AV6cPartidaLinea ;
      private short AV13pPartidaLinea ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A214PartidaLinea ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV12pPartidaId ;
      private int wcpOAV12pPartidaId ;
      private int Grid1_PageSize36 ;
      private int GRID1_nFirstRecordOnPage ;
      private int A207PartidaId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV7cPartidaDebe ;
      private decimal AV8cPartidaHaber ;
      private decimal A215PartidaDebe ;
      private decimal A216PartidaHaber ;
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
      private String edtPartidaLinea_Internalname ;
      private String edtPartidaDebe_Internalname ;
      private String edtPartidaHaber_Internalname ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtTipoParCodigo_Internalname ;
      private String edtPartidaId_Internalname ;
      private String edtavCpartidalinea_Internalname ;
      private String scmdbuf ;
      private String edtavCpartidadebe_Internalname ;
      private String edtavCpartidahaber_Internalname ;
      private String edtavCctacontablecodigo_Internalname ;
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
      private String GXt_char6 ;
      private String edtavLinkselection_Link ;
      private String edtPartidaDebe_Link ;
      private String GXt_char7 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockpartidalinea_Internalname ;
      private String lblTextblockpartidalinea_Jsonclick ;
      private String edtavCpartidalinea_Jsonclick ;
      private String lblTextblockpartidadebe_Internalname ;
      private String lblTextblockpartidadebe_Jsonclick ;
      private String edtavCpartidadebe_Jsonclick ;
      private String lblTextblockpartidahaber_Internalname ;
      private String lblTextblockpartidahaber_Jsonclick ;
      private String edtavCpartidahaber_Jsonclick ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtavCctacontablecodigo_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtPartidaLinea_Jsonclick ;
      private String edtPartidaDebe_Jsonclick ;
      private String edtPartidaHaber_Jsonclick ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoParCodigo_Jsonclick ;
      private String edtPartidaId_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV10pClinicaCodigo ;
      private String AV11pTipoParCodigo ;
      private String wcpOAV10pClinicaCodigo ;
      private String wcpOAV11pTipoParCodigo ;
      private String AV9cCtaContableCodigo ;
      private String A193CtaContableCodigo ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String lV9cCtaContableCodigo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00202_A207PartidaId ;
      private String[] H00202_A199TipoParCodigo ;
      private String[] H00202_A41ClinicaCodigo ;
      private String[] H00202_A193CtaContableCodigo ;
      private decimal[] H00202_A216PartidaHaber ;
      private decimal[] H00202_A215PartidaDebe ;
      private short[] H00202_A214PartidaLinea ;
      private int[] H00203_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP3_pPartidaLinea ;
      private GXWebForm Form ;
   }

   public class gx01i3__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00202 ;
          prmH00202 = new Object[] {
          new Object[] {"@AV10pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11pTipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12pPartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cPartidaLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cPartidaDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV8cPartidaHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@lV9cCtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH00203 ;
          prmH00203 = new Object[] {
          new Object[] {"@AV10pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11pTipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12pPartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cPartidaLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cPartidaDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV8cPartidaHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@lV9cCtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00202", "SELECT [PartidaId], [TipoParCodigo], [ClinicaCodigo], [CtaContableCodigo], [PartidaHaber], [PartidaDebe], [PartidaLinea] FROM [PartidaDet] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV10pClinicaCodigo and [TipoParCodigo] = @AV11pTipoParCodigo and [PartidaId] = @AV12pPartidaId and [PartidaLinea] >= @AV6cPartidaLinea) AND ([PartidaDebe] >= @AV7cPartidaDebe) AND ([PartidaHaber] >= @AV8cPartidaHaber) AND ([CtaContableCodigo] like @lV9cCtaContableCodigo) ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00202,11,0,false,false )
             ,new CursorDef("H00203", "SELECT COUNT(*) FROM [PartidaDet] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV10pClinicaCodigo and [TipoParCodigo] = @AV11pTipoParCodigo and [PartidaId] = @AV12pPartidaId and [PartidaLinea] >= @AV6cPartidaLinea) AND ([PartidaDebe] >= @AV7cPartidaDebe) AND ([PartidaHaber] >= @AV8cPartidaHaber) AND ([CtaContableCodigo] like @lV9cCtaContableCodigo) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00203,1,0,false,false )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
