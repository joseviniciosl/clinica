/*
               File: Gx00Y0
        Description: Selection List Bancos
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:57.71
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
   public class gx00y0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00y0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00y0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out String aP1_pBancoCodigo )
      {
         this.AV9pClinicaCodigo = "" ;
         this.AV10pBancoCodigo = "" ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV9pClinicaCodigo;
         aP1_pBancoCodigo=this.AV10pBancoCodigo;
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
               nGXsfl_31_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_31_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_31_idx, sGXsfl_31_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize31 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cBancoCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBancoCodigo", AV7cBancoCodigo);
               AV8cBancoDescripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBancoDescripcion", AV8cBancoDescripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize31, AV6cClinicaCodigo, AV7cBancoCodigo, AV8cBancoDescripcion) ;
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
               AV9pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pClinicaCodigo", AV9pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10pBancoCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pBancoCodigo", AV10pBancoCodigo);
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
         PA152( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START152( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00y0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV10pBancoCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCBANCOCODIGO", StringUtil.RTrim( AV7cBancoCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCBANCODESCRIPCION", StringUtil.RTrim( AV8cBancoDescripcion));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV9pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPBANCOCODIGO", StringUtil.RTrim( AV10pBancoCodigo));
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
            WE152( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT152( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00Y0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Bancos" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00y0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV10pBancoCodigo)) ;
      }

      protected void WB150( )
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
            wb_table1_2_152( true) ;
         }
         else
         {
            wb_table1_2_152( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_152e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START152( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Bancos", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP150( ) ;
      }

      protected void WS152( )
      {
         START152( ) ;
         EVT152( ) ;
      }

      protected void EVT152( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBANCOCODIGO"), AV7cBancoCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBANCODESCRIPCION"), AV8cBancoDescripcion) != 0 )
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
                              nGXsfl_31_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
                              edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_31_idx ;
                              edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_31_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A126BancoCodigo = cgiGet( edtBancoCodigo_Internalname) ;
                              A127BancoDescripcion = cgiGet( edtBancoDescripcion_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11152 */
                                    E11152 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12152 */
                                    E12152 ();
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
                                       /* Set Refresh If Cbancocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBANCOCODIGO"), AV7cBancoCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbancodescripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBANCODESCRIPCION"), AV8cBancoDescripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13152 */
                                          E13152 ();
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

      protected void WE152( )
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

      protected void PA152( )
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
                                       short nGXsfl_31_idx ,
                                       String sGXsfl_31_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_31_idx ;
         edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_31_idx ;
         while ( nGXsfl_31_idx <= nRC_Grid1 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1)) ;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_31_idx ;
            edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_31_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize31 ,
                                        String AV6cClinicaCodigo ,
                                        String AV7cBancoCodigo ,
                                        String AV8cBancoDescripcion )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize31) ;
         RF152( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF152( ) ;
         /* End function Refresh */
      }

      protected void RF152( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 31 ;
         nGXsfl_31_idx = 1 ;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_31_idx ;
         edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_31_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_31_idx ;
            edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_31_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV7cBancoCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cBancoCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBancoCodigo", AV7cBancoCodigo);
            lV8cBancoDescripcion = StringUtil.PadR( StringUtil.RTrim( AV8cBancoDescripcion), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBancoDescripcion", AV8cBancoDescripcion);
            /* Using cursor H00152 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, lV7cBancoCodigo, lV8cBancoDescripcion});
            nGXsfl_31_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A127BancoDescripcion = H00152_A127BancoDescripcion[0] ;
               A126BancoCodigo = H00152_A126BancoCodigo[0] ;
               A41ClinicaCodigo = H00152_A41ClinicaCodigo[0] ;
               /* Execute user event: E12152 */
               E12152 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 31 ;
            WB150( ) ;
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
         lV7cBancoCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cBancoCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBancoCodigo", AV7cBancoCodigo);
         lV8cBancoDescripcion = StringUtil.PadR( StringUtil.RTrim( AV8cBancoDescripcion), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBancoDescripcion", AV8cBancoDescripcion);
         /* Using cursor H00153 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV7cBancoCodigo, lV8cBancoDescripcion});
         GRID1_nRecordCount = H00153_AGRID1_nRecordCount[0] ;
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

      protected void STRUP150( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11152 */
         E11152 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            AV7cBancoCodigo = cgiGet( edtavCbancocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBancoCodigo", AV7cBancoCodigo);
            AV8cBancoDescripcion = cgiGet( edtavCbancodescripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBancoDescripcion", AV8cBancoDescripcion);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV9pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV10pBancoCodigo = cgiGet( "vPBANCOCODIGO") ;
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
         /* Execute user event: E11152 */
         E11152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11152( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selecci�n %1", "Bancos", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12152( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_312( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E13152 */
         E13152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13152( )
      {
         /* Enter Routine */
         AV9pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pClinicaCodigo", AV9pClinicaCodigo);
         AV10pBancoCodigo = A126BancoCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pBancoCodigo", AV10pBancoCodigo);
         context.setWebReturnParms(new Object[] {(String)AV9pClinicaCodigo,(String)AV10pBancoCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_152( bool wbgen )
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
            wb_table2_9_152( true) ;
         }
         else
         {
            wb_table2_9_152( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_152e( bool wbgen )
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
            wb_table3_28_152( true) ;
         }
         else
         {
            wb_table3_28_152( false) ;
         }
         return  ;
      }

      protected void wb_table3_28_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_152e( true) ;
         }
         else
         {
            wb_table1_2_152e( false) ;
         }
      }

      protected void wb_table3_28_152( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"31\">") ;
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
               context.SendWebValue( "C�digo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "C�digo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Banco") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A126BancoCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A127BancoDescripcion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtBancoDescripcion_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 31 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_31_idx-1) ;
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
            wb_table4_38_152( true) ;
         }
         else
         {
            wb_table4_38_152( false) ;
         }
         return  ;
      }

      protected void wb_table4_38_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_28_152e( true) ;
         }
         else
         {
            wb_table3_28_152e( false) ;
         }
      }

      protected void wb_table4_38_152( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_38_152e( true) ;
         }
         else
         {
            wb_table4_38_152e( false) ;
         }
      }

      protected void wb_table2_9_152( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "C�digo", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_31_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbancocodigo_Internalname, "C�digo", "", "", lblTextblockbancocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBancoCodigo", AV7cBancoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_31_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbancocodigo_Internalname, StringUtil.RTrim( AV7cBancoCodigo), StringUtil.RTrim( context.localUtil.Format( AV7cBancoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCbancocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbancodescripcion_Internalname, "Banco", "", "", lblTextblockbancodescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBancoDescripcion", AV8cBancoDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_31_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbancodescripcion_Internalname, StringUtil.RTrim( AV8cBancoDescripcion), StringUtil.RTrim( context.localUtil.Format( AV8cBancoDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", "", "", "", edtavCbancodescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_152e( true) ;
         }
         else
         {
            wb_table2_9_152e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV9pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pClinicaCodigo", AV9pClinicaCodigo);
         AV10pBancoCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pBancoCodigo", AV10pBancoCodigo);
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
         PA152( ) ;
         WS152( ) ;
         WE152( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1585814");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx00y0.js", "?1585814");
         /* End function include_jscripts */
      }

      protected void sendrow_312( )
      {
         WB150( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_31_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_31_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_31_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A126BancoCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBancoCodigo_Internalname,StringUtil.RTrim( A126BancoCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtBancoCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtBancoDescripcion_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A126BancoCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBancoDescripcion_Internalname,StringUtil.RTrim( A127BancoDescripcion),(String)"",(String)"",(String)"",(String)edtBancoDescripcion_Link,(String)"",(String)"Seleccionar",(String)edtBancoDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_31_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1)) ;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_31_idx ;
            edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_31_idx ;
         }
         /* End function sendrow_312 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblockbancocodigo_Internalname = "TEXTBLOCKBANCOCODIGO" ;
         edtavCbancocodigo_Internalname = "vCBANCOCODIGO" ;
         lblTextblockbancodescripcion_Internalname = "TEXTBLOCKBANCODESCRIPCION" ;
         edtavCbancodescripcion_Internalname = "vCBANCODESCRIPCION" ;
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
         edtBancoDescripcion_Jsonclick = "" ;
         edtBancoCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCbancodescripcion_Jsonclick = "" ;
         edtavCbancocodigo_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtBancoDescripcion_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Bancos" ;
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
         AV7cBancoCodigo = "" ;
         AV8cBancoDescripcion = "" ;
         AV9pClinicaCodigo = "" ;
         AV10pBancoCodigo = "" ;
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
         edtBancoCodigo_Internalname = "" ;
         edtBancoDescripcion_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A126BancoCodigo = "" ;
         A127BancoDescripcion = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV7cBancoCodigo = "" ;
         lV8cBancoDescripcion = "" ;
         H00152_A127BancoDescripcion = new String[] {""} ;
         H00152_A126BancoCodigo = new String[] {""} ;
         H00152_A41ClinicaCodigo = new String[] {""} ;
         H00153_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char3 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockbancocodigo_Jsonclick = "" ;
         lblTextblockbancodescripcion_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char4 = "" ;
         ROClassString = "" ;
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00y0__default(),
            new Object[][] {
                new Object[] {
               H00152_A127BancoDescripcion, H00152_A126BancoCodigo, H00152_A41ClinicaCodigo
               }
               , new Object[] {
               H00153_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_31_idx=1 ;
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
      private int Grid1_PageSize31 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
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
      private String edtBancoCodigo_Internalname ;
      private String edtBancoDescripcion_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCbancocodigo_Internalname ;
      private String edtavCbancodescripcion_Internalname ;
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
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String edtBancoDescripcion_Link ;
      private String GXt_char3 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblockbancocodigo_Internalname ;
      private String lblTextblockbancocodigo_Jsonclick ;
      private String edtavCbancocodigo_Jsonclick ;
      private String lblTextblockbancodescripcion_Internalname ;
      private String lblTextblockbancodescripcion_Jsonclick ;
      private String edtavCbancodescripcion_Jsonclick ;
      private String GXt_char4 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtBancoCodigo_Jsonclick ;
      private String edtBancoDescripcion_Jsonclick ;
      private String GXt_char5 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV7cBancoCodigo ;
      private String AV8cBancoDescripcion ;
      private String AV9pClinicaCodigo ;
      private String AV10pBancoCodigo ;
      private String A41ClinicaCodigo ;
      private String A126BancoCodigo ;
      private String A127BancoDescripcion ;
      private String lV6cClinicaCodigo ;
      private String lV7cBancoCodigo ;
      private String lV8cBancoDescripcion ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00152_A127BancoDescripcion ;
      private String[] H00152_A126BancoCodigo ;
      private String[] H00152_A41ClinicaCodigo ;
      private int[] H00153_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private String aP1_pBancoCodigo ;
      private GXWebForm Form ;
   }

   public class gx00y0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00152 ;
          prmH00152 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cBancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cBancoDescripcion",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH00153 ;
          prmH00153 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cBancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cBancoDescripcion",SqlDbType.VarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00152", "SELECT [BancoDescripcion], [BancoCodigo], [ClinicaCodigo] FROM [Banco] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([BancoCodigo] like @lV7cBancoCodigo) AND ([BancoDescripcion] like @lV8cBancoDescripcion) ORDER BY [ClinicaCodigo], [BancoCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00152,11,0,false,false )
             ,new CursorDef("H00153", "SELECT COUNT(*) FROM [Banco] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([BancoCodigo] like @lV7cBancoCodigo) AND ([BancoDescripcion] like @lV8cBancoDescripcion) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00153,1,0,false,false )
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
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
