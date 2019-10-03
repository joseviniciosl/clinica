/*
               File: Gx01P0
        Description: Selection List Resoluciones de Facturas SAT
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:35.42
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
   public class gx01p0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01p0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01p0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out String aP1_pResolucionCodigo )
      {
         this.AV13pClinicaCodigo = "" ;
         this.AV14pResolucionCodigo = "" ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV13pClinicaCodigo;
         aP1_pResolucionCodigo=this.AV14pResolucionCodigo;
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
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cResolucionCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cResolucionCodigo", AV7cResolucionCodigo);
               AV8cResolucionFecha = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cResolucionFecha", context.localUtil.Format(AV8cResolucionFecha, "99/99/99"));
               AV9cResolucionVencimiento = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cResolucionVencimiento", context.localUtil.Format(AV9cResolucionVencimiento, "99/99/99"));
               AV10cResolucionSerie = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cResolucionSerie", AV10cResolucionSerie);
               AV11cResolucionInicial = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cResolucionInicial), 9, 0)));
               AV12cResolucionFinal = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cResolucionFinal), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cClinicaCodigo, AV7cResolucionCodigo, AV8cResolucionFecha, AV9cResolucionVencimiento, AV10cResolucionSerie, AV11cResolucionInicial, AV12cResolucionFinal) ;
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
               AV13pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pResolucionCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pResolucionCodigo", AV14pResolucionCodigo);
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
         PA2M2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2M2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01p0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pResolucionCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCRESOLUCIONCODIGO", StringUtil.RTrim( AV7cResolucionCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCRESOLUCIONFECHA", context.localUtil.Format(AV8cResolucionFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCRESOLUCIONVENCIMIENTO", context.localUtil.Format(AV9cResolucionVencimiento, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCRESOLUCIONSERIE", StringUtil.RTrim( AV10cResolucionSerie));
         GxWebStd.gx_hidden_field( context, "GXH_vCRESOLUCIONINICIAL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cResolucionInicial), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRESOLUCIONFINAL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cResolucionFinal), 9, 0, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV13pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPRESOLUCIONCODIGO", StringUtil.RTrim( AV14pResolucionCodigo));
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
            WE2M2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2M2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01P0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Resoluciones de Facturas SAT" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01p0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pResolucionCodigo)) ;
      }

      protected void WB2M0( )
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
            wb_table1_2_2M2( true) ;
         }
         else
         {
            wb_table1_2_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2M2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Resoluciones de Facturas SAT", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2M0( ) ;
      }

      protected void WS2M2( )
      {
         START2M2( ) ;
         EVT2M2( ) ;
      }

      protected void EVT2M2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCLINICACODIGO"), AV6cClinicaCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCRESOLUCIONCODIGO"), AV7cResolucionCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCRESOLUCIONFECHA"), 2) != AV8cResolucionFecha )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCRESOLUCIONVENCIMIENTO"), 2) != AV9cResolucionVencimiento )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCRESOLUCIONSERIE"), AV10cResolucionSerie) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRESOLUCIONINICIAL"), ".", ",") != Convert.ToDecimal( AV11cResolucionInicial )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRESOLUCIONFINAL"), ".", ",") != Convert.ToDecimal( AV12cResolucionFinal )) )
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
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
                              edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO_"+sGXsfl_51_idx ;
                              edtResolucionFecha_Internalname = "RESOLUCIONFECHA_"+sGXsfl_51_idx ;
                              edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO_"+sGXsfl_51_idx ;
                              edtResolucionSerie_Internalname = "RESOLUCIONSERIE_"+sGXsfl_51_idx ;
                              edtResolucionInicial_Internalname = "RESOLUCIONINICIAL_"+sGXsfl_51_idx ;
                              edtResolucionFinal_Internalname = "RESOLUCIONFINAL_"+sGXsfl_51_idx ;
                              edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A252ResolucionCodigo = cgiGet( edtResolucionCodigo_Internalname) ;
                              A253ResolucionFecha = context.localUtil.CToD( cgiGet( edtResolucionFecha_Internalname), 2) ;
                              A254ResolucionVencimiento = context.localUtil.CToD( cgiGet( edtResolucionVencimiento_Internalname), 2) ;
                              A255ResolucionSerie = cgiGet( edtResolucionSerie_Internalname) ;
                              A256ResolucionInicial = (int)(context.localUtil.CToN( cgiGet( edtResolucionInicial_Internalname), ".", ",")) ;
                              A257ResolucionFinal = (int)(context.localUtil.CToN( cgiGet( edtResolucionFinal_Internalname), ".", ",")) ;
                              A258ResolucionSiguiente = (int)(context.localUtil.CToN( cgiGet( edtResolucionSiguiente_Internalname), ".", ",")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112M2 */
                                    E112M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122M2 */
                                    E122M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cclinicacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCLINICACODIGO"), AV6cClinicaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cresolucioncodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCRESOLUCIONCODIGO"), AV7cResolucionCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cresolucionfecha Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCRESOLUCIONFECHA"), 2) != AV8cResolucionFecha )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cresolucionvencimiento Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCRESOLUCIONVENCIMIENTO"), 2) != AV9cResolucionVencimiento )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cresolucionserie Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCRESOLUCIONSERIE"), AV10cResolucionSerie) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cresolucioninicial Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRESOLUCIONINICIAL"), ".", ",") != Convert.ToDecimal( AV11cResolucionInicial )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cresolucionfinal Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRESOLUCIONFINAL"), ".", ",") != Convert.ToDecimal( AV12cResolucionFinal )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132M2 */
                                          E132M2 ();
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

      protected void WE2M2( )
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

      protected void PA2M2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCclinicacodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO_"+sGXsfl_51_idx ;
         edtResolucionFecha_Internalname = "RESOLUCIONFECHA_"+sGXsfl_51_idx ;
         edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO_"+sGXsfl_51_idx ;
         edtResolucionSerie_Internalname = "RESOLUCIONSERIE_"+sGXsfl_51_idx ;
         edtResolucionInicial_Internalname = "RESOLUCIONINICIAL_"+sGXsfl_51_idx ;
         edtResolucionFinal_Internalname = "RESOLUCIONFINAL_"+sGXsfl_51_idx ;
         edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO_"+sGXsfl_51_idx ;
            edtResolucionFecha_Internalname = "RESOLUCIONFECHA_"+sGXsfl_51_idx ;
            edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO_"+sGXsfl_51_idx ;
            edtResolucionSerie_Internalname = "RESOLUCIONSERIE_"+sGXsfl_51_idx ;
            edtResolucionInicial_Internalname = "RESOLUCIONINICIAL_"+sGXsfl_51_idx ;
            edtResolucionFinal_Internalname = "RESOLUCIONFINAL_"+sGXsfl_51_idx ;
            edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cClinicaCodigo ,
                                        String AV7cResolucionCodigo ,
                                        DateTime AV8cResolucionFecha ,
                                        DateTime AV9cResolucionVencimiento ,
                                        String AV10cResolucionSerie ,
                                        int AV11cResolucionInicial ,
                                        int AV12cResolucionFinal )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2M2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2M2( ) ;
         /* End function Refresh */
      }

      protected void RF2M2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO_"+sGXsfl_51_idx ;
         edtResolucionFecha_Internalname = "RESOLUCIONFECHA_"+sGXsfl_51_idx ;
         edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO_"+sGXsfl_51_idx ;
         edtResolucionSerie_Internalname = "RESOLUCIONSERIE_"+sGXsfl_51_idx ;
         edtResolucionInicial_Internalname = "RESOLUCIONINICIAL_"+sGXsfl_51_idx ;
         edtResolucionFinal_Internalname = "RESOLUCIONFINAL_"+sGXsfl_51_idx ;
         edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO_"+sGXsfl_51_idx ;
            edtResolucionFecha_Internalname = "RESOLUCIONFECHA_"+sGXsfl_51_idx ;
            edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO_"+sGXsfl_51_idx ;
            edtResolucionSerie_Internalname = "RESOLUCIONSERIE_"+sGXsfl_51_idx ;
            edtResolucionInicial_Internalname = "RESOLUCIONINICIAL_"+sGXsfl_51_idx ;
            edtResolucionFinal_Internalname = "RESOLUCIONFINAL_"+sGXsfl_51_idx ;
            edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE_"+sGXsfl_51_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV7cResolucionCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cResolucionCodigo), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cResolucionCodigo", AV7cResolucionCodigo);
            lV10cResolucionSerie = StringUtil.PadR( StringUtil.RTrim( AV10cResolucionSerie), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cResolucionSerie", AV10cResolucionSerie);
            /* Using cursor H002M2 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, lV7cResolucionCodigo, AV8cResolucionFecha, AV9cResolucionVencimiento, lV10cResolucionSerie, AV11cResolucionInicial, AV12cResolucionFinal});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A258ResolucionSiguiente = H002M2_A258ResolucionSiguiente[0] ;
               A257ResolucionFinal = H002M2_A257ResolucionFinal[0] ;
               A256ResolucionInicial = H002M2_A256ResolucionInicial[0] ;
               A255ResolucionSerie = H002M2_A255ResolucionSerie[0] ;
               A254ResolucionVencimiento = H002M2_A254ResolucionVencimiento[0] ;
               A253ResolucionFecha = H002M2_A253ResolucionFecha[0] ;
               A252ResolucionCodigo = H002M2_A252ResolucionCodigo[0] ;
               A41ClinicaCodigo = H002M2_A41ClinicaCodigo[0] ;
               /* Execute user event: E122M2 */
               E122M2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB2M0( ) ;
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
         lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
         lV7cResolucionCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cResolucionCodigo), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cResolucionCodigo", AV7cResolucionCodigo);
         lV10cResolucionSerie = StringUtil.PadR( StringUtil.RTrim( AV10cResolucionSerie), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cResolucionSerie", AV10cResolucionSerie);
         /* Using cursor H002M3 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV7cResolucionCodigo, AV8cResolucionFecha, AV9cResolucionVencimiento, lV10cResolucionSerie, AV11cResolucionInicial, AV12cResolucionFinal});
         GRID1_nRecordCount = H002M3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2M0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112M2 */
         E112M2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            AV7cResolucionCodigo = cgiGet( edtavCresolucioncodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cResolucionCodigo", AV7cResolucionCodigo);
            if ( context.localUtil.VCDate( cgiGet( edtavCresolucionfecha_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "vCRESOLUCIONFECHA");
               GX_FocusControl = edtavCresolucionfecha_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cResolucionFecha = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cResolucionFecha", context.localUtil.Format(AV8cResolucionFecha, "99/99/99"));
            }
            else
            {
               AV8cResolucionFecha = context.localUtil.CToD( cgiGet( edtavCresolucionfecha_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cResolucionFecha", context.localUtil.Format(AV8cResolucionFecha, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCresolucionvencimiento_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Vencimiento"}), 1, "vCRESOLUCIONVENCIMIENTO");
               GX_FocusControl = edtavCresolucionvencimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cResolucionVencimiento = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cResolucionVencimiento", context.localUtil.Format(AV9cResolucionVencimiento, "99/99/99"));
            }
            else
            {
               AV9cResolucionVencimiento = context.localUtil.CToD( cgiGet( edtavCresolucionvencimiento_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cResolucionVencimiento", context.localUtil.Format(AV9cResolucionVencimiento, "99/99/99"));
            }
            AV10cResolucionSerie = cgiGet( edtavCresolucionserie_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cResolucionSerie", AV10cResolucionSerie);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCresolucioninicial_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCresolucioninicial_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCRESOLUCIONINICIAL");
               GX_FocusControl = edtavCresolucioninicial_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cResolucionInicial = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cResolucionInicial), 9, 0)));
            }
            else
            {
               AV11cResolucionInicial = (int)(context.localUtil.CToN( cgiGet( edtavCresolucioninicial_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cResolucionInicial), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCresolucionfinal_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCresolucionfinal_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCRESOLUCIONFINAL");
               GX_FocusControl = edtavCresolucionfinal_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cResolucionFinal = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cResolucionFinal), 9, 0)));
            }
            else
            {
               AV12cResolucionFinal = (int)(context.localUtil.CToN( cgiGet( edtavCresolucionfinal_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cResolucionFinal), 9, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV13pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV14pResolucionCodigo = cgiGet( "vPRESOLUCIONCODIGO") ;
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
         /* Execute user event: E112M2 */
         E112M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112M2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Resoluciones de Facturas SAT", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122M2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132M2 */
         E132M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132M2( )
      {
         /* Enter Routine */
         AV13pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pResolucionCodigo = A252ResolucionCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pResolucionCodigo", AV14pResolucionCodigo);
         context.setWebReturnParms(new Object[] {(String)AV13pClinicaCodigo,(String)AV14pResolucionCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2M2( bool wbgen )
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
            wb_table2_9_2M2( true) ;
         }
         else
         {
            wb_table2_9_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2M2e( bool wbgen )
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
            wb_table3_48_2M2( true) ;
         }
         else
         {
            wb_table3_48_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2M2e( true) ;
         }
         else
         {
            wb_table1_2_2M2e( false) ;
         }
      }

      protected void wb_table3_48_2M2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"51\">") ;
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
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Resolución") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Vencimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Serie") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Inicial") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Final") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Siguiente") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A252ResolucionCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A253ResolucionFecha, "99/99/99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtResolucionFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A255ResolucionSerie));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A256ResolucionInicial), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A257ResolucionFinal), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A258ResolucionSiguiente), 9, 0, ".", "")));
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
            wb_table4_63_2M2( true) ;
         }
         else
         {
            wb_table4_63_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table4_63_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2M2e( true) ;
         }
         else
         {
            wb_table3_48_2M2e( false) ;
         }
      }

      protected void wb_table4_63_2M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_63_2M2e( true) ;
         }
         else
         {
            wb_table4_63_2M2e( false) ;
         }
      }

      protected void wb_table2_9_2M2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucioncodigo_Internalname, "Resolución", "", "", lblTextblockresolucioncodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cResolucionCodigo", AV7cResolucionCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCresolucioncodigo_Internalname, StringUtil.RTrim( AV7cResolucionCodigo), StringUtil.RTrim( context.localUtil.Format( AV7cResolucionCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCresolucioncodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionfecha_Internalname, "Fecha", "", "", lblTextblockresolucionfecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cResolucionFecha", context.localUtil.Format(AV8cResolucionFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCresolucionfecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCresolucionfecha_Internalname, context.localUtil.Format(AV8cResolucionFecha, "99/99/99"), context.localUtil.Format( AV8cResolucionFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCresolucionfecha_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01P0.htm");
            GxWebStd.gx_bitmap( context, edtavCresolucionfecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx01P0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionvencimiento_Internalname, "Vencimiento", "", "", lblTextblockresolucionvencimiento_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cResolucionVencimiento", context.localUtil.Format(AV9cResolucionVencimiento, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCresolucionvencimiento_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCresolucionvencimiento_Internalname, context.localUtil.Format(AV9cResolucionVencimiento, "99/99/99"), context.localUtil.Format( AV9cResolucionVencimiento, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCresolucionvencimiento_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01P0.htm");
            GxWebStd.gx_bitmap( context, edtavCresolucionvencimiento_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx01P0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionserie_Internalname, "Serie", "", "", lblTextblockresolucionserie_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cResolucionSerie", AV10cResolucionSerie);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCresolucionserie_Internalname, StringUtil.RTrim( AV10cResolucionSerie), StringUtil.RTrim( context.localUtil.Format( AV10cResolucionSerie, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", "", "", "", edtavCresolucionserie_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucioninicial_Internalname, "Inicial", "", "", lblTextblockresolucioninicial_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cResolucionInicial", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cResolucionInicial), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCresolucioninicial_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cResolucionInicial), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cResolucionInicial), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11cResolucionInicial), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(39);\"", "", "", "", "", edtavCresolucioninicial_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockresolucionfinal_Internalname, "Final", "", "", lblTextblockresolucionfinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cResolucionFinal", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cResolucionFinal), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCresolucionfinal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cResolucionFinal), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cResolucionFinal), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV12cResolucionFinal), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(44);\"", "", "", "", "", edtavCresolucionfinal_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2M2e( true) ;
         }
         else
         {
            wb_table2_9_2M2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pResolucionCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pResolucionCodigo", AV14pResolucionCodigo);
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
         PA2M2( ) ;
         WS2M2( ) ;
         WE2M2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1593623");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx01p0.js", "?1593624");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2M0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_51_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A252ResolucionCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionCodigo_Internalname,StringUtil.RTrim( A252ResolucionCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtResolucionCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtResolucionFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A252ResolucionCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionFecha_Internalname,context.localUtil.Format(A253ResolucionFecha, "99/99/99"),context.localUtil.Format( A253ResolucionFecha, "99/99/99"),(String)"",(String)"",(String)edtResolucionFecha_Link,(String)"",(String)"Seleccionar",(String)edtResolucionFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionVencimiento_Internalname,context.localUtil.Format(A254ResolucionVencimiento, "99/99/99"),context.localUtil.Format( A254ResolucionVencimiento, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtResolucionVencimiento_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionSerie_Internalname,StringUtil.RTrim( A255ResolucionSerie),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtResolucionSerie_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionInicial_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A256ResolucionInicial), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A256ResolucionInicial), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtResolucionInicial_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionFinal_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A257ResolucionFinal), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A257ResolucionFinal), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtResolucionFinal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtResolucionSiguiente_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A258ResolucionSiguiente), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A258ResolucionSiguiente), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtResolucionSiguiente_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtResolucionCodigo_Internalname = "RESOLUCIONCODIGO_"+sGXsfl_51_idx ;
            edtResolucionFecha_Internalname = "RESOLUCIONFECHA_"+sGXsfl_51_idx ;
            edtResolucionVencimiento_Internalname = "RESOLUCIONVENCIMIENTO_"+sGXsfl_51_idx ;
            edtResolucionSerie_Internalname = "RESOLUCIONSERIE_"+sGXsfl_51_idx ;
            edtResolucionInicial_Internalname = "RESOLUCIONINICIAL_"+sGXsfl_51_idx ;
            edtResolucionFinal_Internalname = "RESOLUCIONFINAL_"+sGXsfl_51_idx ;
            edtResolucionSiguiente_Internalname = "RESOLUCIONSIGUIENTE_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblockresolucioncodigo_Internalname = "TEXTBLOCKRESOLUCIONCODIGO" ;
         edtavCresolucioncodigo_Internalname = "vCRESOLUCIONCODIGO" ;
         lblTextblockresolucionfecha_Internalname = "TEXTBLOCKRESOLUCIONFECHA" ;
         edtavCresolucionfecha_Internalname = "vCRESOLUCIONFECHA" ;
         lblTextblockresolucionvencimiento_Internalname = "TEXTBLOCKRESOLUCIONVENCIMIENTO" ;
         edtavCresolucionvencimiento_Internalname = "vCRESOLUCIONVENCIMIENTO" ;
         lblTextblockresolucionserie_Internalname = "TEXTBLOCKRESOLUCIONSERIE" ;
         edtavCresolucionserie_Internalname = "vCRESOLUCIONSERIE" ;
         lblTextblockresolucioninicial_Internalname = "TEXTBLOCKRESOLUCIONINICIAL" ;
         edtavCresolucioninicial_Internalname = "vCRESOLUCIONINICIAL" ;
         lblTextblockresolucionfinal_Internalname = "TEXTBLOCKRESOLUCIONFINAL" ;
         edtavCresolucionfinal_Internalname = "vCRESOLUCIONFINAL" ;
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
         edtResolucionSiguiente_Jsonclick = "" ;
         edtResolucionFinal_Jsonclick = "" ;
         edtResolucionInicial_Jsonclick = "" ;
         edtResolucionSerie_Jsonclick = "" ;
         edtResolucionVencimiento_Jsonclick = "" ;
         edtResolucionFecha_Jsonclick = "" ;
         edtResolucionCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCresolucionfinal_Jsonclick = "" ;
         edtavCresolucioninicial_Jsonclick = "" ;
         edtavCresolucionserie_Jsonclick = "" ;
         edtavCresolucionvencimiento_Jsonclick = "" ;
         edtavCresolucionfecha_Jsonclick = "" ;
         edtavCresolucioncodigo_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtResolucionFecha_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Resoluciones de Facturas SAT" ;
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
         AV6cClinicaCodigo = "" ;
         AV7cResolucionCodigo = "" ;
         AV8cResolucionFecha = DateTime.MinValue ;
         AV9cResolucionVencimiento = DateTime.MinValue ;
         AV10cResolucionSerie = "" ;
         AV13pClinicaCodigo = "" ;
         AV14pResolucionCodigo = "" ;
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
         edtClinicaCodigo_Internalname = "" ;
         edtResolucionCodigo_Internalname = "" ;
         edtResolucionFecha_Internalname = "" ;
         edtResolucionVencimiento_Internalname = "" ;
         edtResolucionSerie_Internalname = "" ;
         edtResolucionInicial_Internalname = "" ;
         edtResolucionFinal_Internalname = "" ;
         edtResolucionSiguiente_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A252ResolucionCodigo = "" ;
         A253ResolucionFecha = DateTime.MinValue ;
         A254ResolucionVencimiento = DateTime.MinValue ;
         A255ResolucionSerie = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV7cResolucionCodigo = "" ;
         lV10cResolucionSerie = "" ;
         H002M2_A258ResolucionSiguiente = new int[1] ;
         H002M2_A257ResolucionFinal = new int[1] ;
         H002M2_A256ResolucionInicial = new int[1] ;
         H002M2_A255ResolucionSerie = new String[] {""} ;
         H002M2_A254ResolucionVencimiento = new DateTime[] {DateTime.MinValue} ;
         H002M2_A253ResolucionFecha = new DateTime[] {DateTime.MinValue} ;
         H002M2_A252ResolucionCodigo = new String[] {""} ;
         H002M2_A41ClinicaCodigo = new String[] {""} ;
         H002M3_AGRID1_nRecordCount = new int[1] ;
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
         GXt_char7 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockresolucioncodigo_Jsonclick = "" ;
         lblTextblockresolucionfecha_Jsonclick = "" ;
         lblTextblockresolucionvencimiento_Jsonclick = "" ;
         GXt_char8 = "" ;
         lblTextblockresolucionserie_Jsonclick = "" ;
         lblTextblockresolucioninicial_Jsonclick = "" ;
         lblTextblockresolucionfinal_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char9 = "" ;
         ROClassString = "" ;
         GXt_char10 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01p0__default(),
            new Object[][] {
                new Object[] {
               H002M2_A258ResolucionSiguiente, H002M2_A257ResolucionFinal, H002M2_A256ResolucionInicial, H002M2_A255ResolucionSerie, H002M2_A254ResolucionVencimiento, H002M2_A253ResolucionFecha, H002M2_A252ResolucionCodigo, H002M2_A41ClinicaCodigo
               }
               , new Object[] {
               H002M3_AGRID1_nRecordCount
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
      private int Grid1_PageSize51 ;
      private int AV11cResolucionInicial ;
      private int AV12cResolucionFinal ;
      private int GRID1_nFirstRecordOnPage ;
      private int A256ResolucionInicial ;
      private int A257ResolucionFinal ;
      private int A258ResolucionSiguiente ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtResolucionCodigo_Internalname ;
      private String edtResolucionFecha_Internalname ;
      private String edtResolucionVencimiento_Internalname ;
      private String edtResolucionSerie_Internalname ;
      private String edtResolucionInicial_Internalname ;
      private String edtResolucionFinal_Internalname ;
      private String edtResolucionSiguiente_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCresolucioncodigo_Internalname ;
      private String edtavCresolucionfecha_Internalname ;
      private String edtavCresolucionvencimiento_Internalname ;
      private String edtavCresolucionserie_Internalname ;
      private String edtavCresolucioninicial_Internalname ;
      private String edtavCresolucionfinal_Internalname ;
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
      private String GXt_char7 ;
      private String edtavLinkselection_Link ;
      private String edtResolucionFecha_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblockresolucioncodigo_Internalname ;
      private String lblTextblockresolucioncodigo_Jsonclick ;
      private String edtavCresolucioncodigo_Jsonclick ;
      private String lblTextblockresolucionfecha_Internalname ;
      private String lblTextblockresolucionfecha_Jsonclick ;
      private String edtavCresolucionfecha_Jsonclick ;
      private String lblTextblockresolucionvencimiento_Internalname ;
      private String lblTextblockresolucionvencimiento_Jsonclick ;
      private String edtavCresolucionvencimiento_Jsonclick ;
      private String GXt_char8 ;
      private String lblTextblockresolucionserie_Internalname ;
      private String lblTextblockresolucionserie_Jsonclick ;
      private String edtavCresolucionserie_Jsonclick ;
      private String lblTextblockresolucioninicial_Internalname ;
      private String lblTextblockresolucioninicial_Jsonclick ;
      private String edtavCresolucioninicial_Jsonclick ;
      private String lblTextblockresolucionfinal_Internalname ;
      private String lblTextblockresolucionfinal_Jsonclick ;
      private String edtavCresolucionfinal_Jsonclick ;
      private String GXt_char9 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtResolucionCodigo_Jsonclick ;
      private String edtResolucionFecha_Jsonclick ;
      private String edtResolucionVencimiento_Jsonclick ;
      private String edtResolucionSerie_Jsonclick ;
      private String edtResolucionInicial_Jsonclick ;
      private String edtResolucionFinal_Jsonclick ;
      private String edtResolucionSiguiente_Jsonclick ;
      private String GXt_char10 ;
      private DateTime AV8cResolucionFecha ;
      private DateTime AV9cResolucionVencimiento ;
      private DateTime A253ResolucionFecha ;
      private DateTime A254ResolucionVencimiento ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV7cResolucionCodigo ;
      private String AV10cResolucionSerie ;
      private String AV13pClinicaCodigo ;
      private String AV14pResolucionCodigo ;
      private String A41ClinicaCodigo ;
      private String A252ResolucionCodigo ;
      private String A255ResolucionSerie ;
      private String lV6cClinicaCodigo ;
      private String lV7cResolucionCodigo ;
      private String lV10cResolucionSerie ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H002M2_A258ResolucionSiguiente ;
      private int[] H002M2_A257ResolucionFinal ;
      private int[] H002M2_A256ResolucionInicial ;
      private String[] H002M2_A255ResolucionSerie ;
      private DateTime[] H002M2_A254ResolucionVencimiento ;
      private DateTime[] H002M2_A253ResolucionFecha ;
      private String[] H002M2_A252ResolucionCodigo ;
      private String[] H002M2_A41ClinicaCodigo ;
      private int[] H002M3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private String aP1_pResolucionCodigo ;
      private GXWebForm Form ;
   }

   public class gx01p0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002M2 ;
          prmH002M2 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cResolucionCodigo",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV8cResolucionFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cResolucionVencimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV10cResolucionSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV11cResolucionInicial",SqlDbType.Int,9,0} ,
          new Object[] {"@AV12cResolucionFinal",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002M3 ;
          prmH002M3 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cResolucionCodigo",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV8cResolucionFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cResolucionVencimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV10cResolucionSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV11cResolucionInicial",SqlDbType.Int,9,0} ,
          new Object[] {"@AV12cResolucionFinal",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002M2", "SELECT [ResolucionSiguiente], [ResolucionFinal], [ResolucionInicial], [ResolucionSerie], [ResolucionVencimiento], [ResolucionFecha], [ResolucionCodigo], [ClinicaCodigo] FROM [ResolucionSAT] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([ResolucionCodigo] like @lV7cResolucionCodigo) AND ([ResolucionFecha] >= @AV8cResolucionFecha) AND ([ResolucionVencimiento] >= @AV9cResolucionVencimiento) AND ([ResolucionSerie] like @lV10cResolucionSerie) AND ([ResolucionInicial] >= @AV11cResolucionInicial) AND ([ResolucionFinal] >= @AV12cResolucionFinal) ORDER BY [ClinicaCodigo], [ResolucionCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M2,11,0,false,false )
             ,new CursorDef("H002M3", "SELECT COUNT(*) FROM [ResolucionSAT] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([ResolucionCodigo] like @lV7cResolucionCodigo) AND ([ResolucionFecha] >= @AV8cResolucionFecha) AND ([ResolucionVencimiento] >= @AV9cResolucionVencimiento) AND ([ResolucionSerie] like @lV10cResolucionSerie) AND ([ResolucionInicial] >= @AV11cResolucionInicial) AND ([ResolucionFinal] >= @AV12cResolucionFinal) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M3,1,0,false,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
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
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
       }
    }

 }

}
