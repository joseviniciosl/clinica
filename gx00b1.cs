/*
               File: Gx00B1
        Description: Selection List Sub-Categorías
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:57.41
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
   public class gx00b1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00b1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00b1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           out String aP1_pCategoriaCodigo ,
                           out String aP2_pSubCategoriaCodigo )
      {
         this.AV9pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV10pCategoriaCodigo = "" ;
         this.AV11pSubCategoriaCodigo = "" ;
         executePrivate();
         aP1_pCategoriaCodigo=this.AV10pCategoriaCodigo;
         aP2_pSubCategoriaCodigo=this.AV11pSubCategoriaCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynCategoriaCodigo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"CATEGORIACODIGO") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLACATEGORIACODIGO3L2( ) ;
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
               GXCCtl = "CATEGORIACODIGO_" + sGXsfl_31_idx ;
               dynCategoriaCodigo.Name = GXCCtl ;
               dynCategoriaCodigo.WebTags = "" ;
               Grid1_PageSize31 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cCategoriaDescripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCategoriaDescripcion", AV6cCategoriaDescripcion);
               AV7cSubCategoriaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSubCategoriaCodigo", AV7cSubCategoriaCodigo);
               AV8cSubCategoriaDescripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSubCategoriaDescripcion", AV8cSubCategoriaDescripcion);
               AV9pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pClinicaCodigo", AV9pClinicaCodigo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize31, AV6cCategoriaDescripcion, AV7cSubCategoriaCodigo, AV8cSubCategoriaDescripcion, AV9pClinicaCodigo) ;
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
                  AV10pCategoriaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pCategoriaCodigo", AV10pCategoriaCodigo);
                  AV11pSubCategoriaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSubCategoriaCodigo", AV11pSubCategoriaCodigo);
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
         PA3L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3L2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00b1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV10pCategoriaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV11pSubCategoriaCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCATEGORIADESCRIPCION", StringUtil.RTrim( AV6cCategoriaDescripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vCSUBCATEGORIACODIGO", StringUtil.RTrim( AV7cSubCategoriaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCSUBCATEGORIADESCRIPCION", StringUtil.RTrim( AV8cSubCategoriaDescripcion));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV9pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPCATEGORIACODIGO", StringUtil.RTrim( AV10pCategoriaCodigo));
         GxWebStd.gx_hidden_field( context, "vPSUBCATEGORIACODIGO", StringUtil.RTrim( AV11pSubCategoriaCodigo));
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
            WE3L2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00B1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Sub-Categorías" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00b1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV10pCategoriaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV11pSubCategoriaCodigo)) ;
      }

      protected void WB3L0( )
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
            wb_table1_2_3L2( true) ;
         }
         else
         {
            wb_table1_2_3L2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3L2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START3L2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Sub-Categorías", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP3L0( ) ;
      }

      protected void WS3L2( )
      {
         START3L2( ) ;
         EVT3L2( ) ;
      }

      protected void EVT3L2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCATEGORIADESCRIPCION"), AV6cCategoriaDescripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCSUBCATEGORIACODIGO"), AV7cSubCategoriaCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCSUBCATEGORIADESCRIPCION"), AV8cSubCategoriaDescripcion) != 0 )
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
                              edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION_"+sGXsfl_31_idx ;
                              edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_31_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
                              dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_31_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A28CategoriaDescripcion = cgiGet( edtCategoriaDescripcion_Internalname) ;
                              A124SubCategoriaCodigo = cgiGet( edtSubCategoriaCodigo_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              dynCategoriaCodigo.Name = dynCategoriaCodigo_Internalname ;
                              dynCategoriaCodigo.CurrentValue = cgiGet( dynCategoriaCodigo_Internalname) ;
                              A27CategoriaCodigo = cgiGet( dynCategoriaCodigo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E113L2 */
                                    E113L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E123L2 */
                                    E123L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ccategoriadescripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCATEGORIADESCRIPCION"), AV6cCategoriaDescripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csubcategoriacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSUBCATEGORIACODIGO"), AV7cSubCategoriaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csubcategoriadescripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSUBCATEGORIADESCRIPCION"), AV8cSubCategoriaDescripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E133L2 */
                                          E133L2 ();
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

      protected void WE3L2( )
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

      protected void PA3L2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "CATEGORIACODIGO_" + sGXsfl_31_idx ;
            dynCategoriaCodigo.Name = GXCCtl ;
            dynCategoriaCodigo.WebTags = "" ;
            GX_FocusControl = edtavCcategoriadescripcion_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLACATEGORIACODIGO3L2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLACATEGORIACODIGO_data3L2( ) ;
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

      protected void GXACATEGORIACODIGO_html3L2( )
      {
         String gxdynajaxvalue ;
         GXDLACATEGORIACODIGO_data3L2( ) ;
         gxdynajaxindex = 1 ;
         dynCategoriaCodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynCategoriaCodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLACATEGORIACODIGO_data3L2( )
      {
         /* Using cursor H003L2 */
         pr_default.execute(0);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H003L2_A27CategoriaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H003L2_A28CategoriaDescripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_31_idx ,
                                       String sGXsfl_31_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
         edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION_"+sGXsfl_31_idx ;
         edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_31_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
         dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_31_idx ;
         while ( nGXsfl_31_idx <= nRC_Grid1 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1)) ;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
            edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION_"+sGXsfl_31_idx ;
            edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_31_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
            dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_31_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize31 ,
                                        String AV6cCategoriaDescripcion ,
                                        String AV7cSubCategoriaCodigo ,
                                        String AV8cSubCategoriaDescripcion ,
                                        String AV9pClinicaCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize31) ;
         RF3L2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF3L2( ) ;
         /* End function Refresh */
      }

      protected void RF3L2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 31 ;
         nGXsfl_31_idx = 1 ;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
         edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION_"+sGXsfl_31_idx ;
         edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_31_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
         dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_31_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
            edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION_"+sGXsfl_31_idx ;
            edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_31_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
            dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_31_idx ;
            lV6cCategoriaDescripcion = StringUtil.PadR( StringUtil.RTrim( AV6cCategoriaDescripcion), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCategoriaDescripcion", AV6cCategoriaDescripcion);
            lV7cSubCategoriaCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cSubCategoriaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSubCategoriaCodigo", AV7cSubCategoriaCodigo);
            lV8cSubCategoriaDescripcion = StringUtil.PadR( StringUtil.RTrim( AV8cSubCategoriaDescripcion), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSubCategoriaDescripcion", AV8cSubCategoriaDescripcion);
            /* Using cursor H003L3 */
            pr_default.execute(1, new Object[] {AV9pClinicaCodigo, lV6cCategoriaDescripcion, lV7cSubCategoriaCodigo, lV8cSubCategoriaDescripcion});
            nGXsfl_31_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A125SubCategoriaDescripcion = H003L3_A125SubCategoriaDescripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125SubCategoriaDescripcion", A125SubCategoriaDescripcion);
               A27CategoriaCodigo = H003L3_A27CategoriaCodigo[0] ;
               A41ClinicaCodigo = H003L3_A41ClinicaCodigo[0] ;
               A124SubCategoriaCodigo = H003L3_A124SubCategoriaCodigo[0] ;
               A28CategoriaDescripcion = H003L3_A28CategoriaDescripcion[0] ;
               A28CategoriaDescripcion = H003L3_A28CategoriaDescripcion[0] ;
               /* Execute user event: E123L2 */
               E123L2 ();
               pr_default.readNext(1);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 31 ;
            WB3L0( ) ;
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
         lV6cCategoriaDescripcion = StringUtil.PadR( StringUtil.RTrim( AV6cCategoriaDescripcion), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCategoriaDescripcion", AV6cCategoriaDescripcion);
         lV7cSubCategoriaCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cSubCategoriaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSubCategoriaCodigo", AV7cSubCategoriaCodigo);
         lV8cSubCategoriaDescripcion = StringUtil.PadR( StringUtil.RTrim( AV8cSubCategoriaDescripcion), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSubCategoriaDescripcion", AV8cSubCategoriaDescripcion);
         /* Using cursor H003L4 */
         pr_default.execute(2, new Object[] {AV9pClinicaCodigo, lV6cCategoriaDescripcion, lV7cSubCategoriaCodigo, lV8cSubCategoriaDescripcion});
         GRID1_nRecordCount = H003L4_AGRID1_nRecordCount[0] ;
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

      protected void STRUP3L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         GXACATEGORIACODIGO_html3L2( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E113L2 */
         E113L2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cCategoriaDescripcion = cgiGet( edtavCcategoriadescripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCategoriaDescripcion", AV6cCategoriaDescripcion);
            AV7cSubCategoriaCodigo = cgiGet( edtavCsubcategoriacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSubCategoriaCodigo", AV7cSubCategoriaCodigo);
            AV8cSubCategoriaDescripcion = cgiGet( edtavCsubcategoriadescripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSubCategoriaDescripcion", AV8cSubCategoriaDescripcion);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV9pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV10pCategoriaCodigo = cgiGet( "vPCATEGORIACODIGO") ;
            AV11pSubCategoriaCodigo = cgiGet( "vPSUBCATEGORIACODIGO") ;
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
         /* Execute user event: E113L2 */
         E113L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113L2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Sub-Categorías", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E123L2( )
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
         /* Execute user event: E133L2 */
         E133L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E133L2( )
      {
         /* Enter Routine */
         AV10pCategoriaCodigo = A27CategoriaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pCategoriaCodigo", AV10pCategoriaCodigo);
         AV11pSubCategoriaCodigo = A124SubCategoriaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSubCategoriaCodigo", AV11pSubCategoriaCodigo);
         context.setWebReturnParms(new Object[] {(String)AV10pCategoriaCodigo,(String)AV11pSubCategoriaCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_3L2( bool wbgen )
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
            wb_table2_9_3L2( true) ;
         }
         else
         {
            wb_table2_9_3L2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_3L2e( bool wbgen )
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
            wb_table3_28_3L2( true) ;
         }
         else
         {
            wb_table3_28_3L2( false) ;
         }
         return  ;
      }

      protected void wb_table3_28_3L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3L2e( true) ;
         }
         else
         {
            wb_table1_2_3L2e( false) ;
         }
      }

      protected void wb_table3_28_3L2( bool wbgen )
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
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Categoría") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Categoría") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A28CategoriaDescripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A124SubCategoriaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A27CategoriaCodigo));
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
            wb_table4_39_3L2( true) ;
         }
         else
         {
            wb_table4_39_3L2( false) ;
         }
         return  ;
      }

      protected void wb_table4_39_3L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_28_3L2e( true) ;
         }
         else
         {
            wb_table3_28_3L2e( false) ;
         }
      }

      protected void wb_table4_39_3L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_39_3L2e( true) ;
         }
         else
         {
            wb_table4_39_3L2e( false) ;
         }
      }

      protected void wb_table2_9_3L2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockcategoriadescripcion_Internalname, "Descripción", "", "", lblTextblockcategoriadescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCategoriaDescripcion", AV6cCategoriaDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_31_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcategoriadescripcion_Internalname, StringUtil.RTrim( AV6cCategoriaDescripcion), StringUtil.RTrim( context.localUtil.Format( AV6cCategoriaDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCcategoriadescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksubcategoriacodigo_Internalname, "Sub_Categoría", "", "", lblTextblocksubcategoriacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSubCategoriaCodigo", AV7cSubCategoriaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_31_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsubcategoriacodigo_Internalname, StringUtil.RTrim( AV7cSubCategoriaCodigo), StringUtil.RTrim( context.localUtil.Format( AV7cSubCategoriaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCsubcategoriacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksubcategoriadescripcion_Internalname, "Descripción", "", "", lblTextblocksubcategoriadescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSubCategoriaDescripcion", AV8cSubCategoriaDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_31_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsubcategoriadescripcion_Internalname, StringUtil.RTrim( AV8cSubCategoriaDescripcion), StringUtil.RTrim( context.localUtil.Format( AV8cSubCategoriaDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", "", "", "", edtavCsubcategoriadescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00B1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_3L2e( true) ;
         }
         else
         {
            wb_table2_9_3L2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV9pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pClinicaCodigo", AV9pClinicaCodigo);
         AV10pCategoriaCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pCategoriaCodigo", AV10pCategoriaCodigo);
         AV11pSubCategoriaCodigo = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSubCategoriaCodigo", AV11pSubCategoriaCodigo);
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
         PA3L2( ) ;
         WS3L2( ) ;
         WE3L2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1595777");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx00b1.js", "?1595777");
         /* End function include_jscripts */
      }

      protected void sendrow_312( )
      {
         WB3L0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A27CategoriaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A124SubCategoriaCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCategoriaDescripcion_Internalname,StringUtil.RTrim( A28CategoriaDescripcion),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCategoriaDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubCategoriaCodigo_Internalname,StringUtil.RTrim( A124SubCategoriaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSubCategoriaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)1,(bool)true,(String)"left"});
            GXACATEGORIACODIGO_html3L2( ) ;
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_31_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CATEGORIACODIGO_" + sGXsfl_31_idx ;
               dynCategoriaCodigo.Name = GXCCtl ;
               dynCategoriaCodigo.WebTags = "" ;
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynCategoriaCodigo,(String)dynCategoriaCodigo_Internalname,(String)A27CategoriaCodigo,(short)1,(String)dynCategoriaCodigo_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            dynCategoriaCodigo.CurrentValue = A27CategoriaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynCategoriaCodigo_Internalname, "Values", (String)(dynCategoriaCodigo.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_31_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1)) ;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_31_idx ;
            edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION_"+sGXsfl_31_idx ;
            edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_31_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_31_idx ;
            dynCategoriaCodigo_Internalname = "CATEGORIACODIGO_"+sGXsfl_31_idx ;
         }
         /* End function sendrow_312 */
      }

      protected void init_default_properties( )
      {
         lblTextblockcategoriadescripcion_Internalname = "TEXTBLOCKCATEGORIADESCRIPCION" ;
         edtavCcategoriadescripcion_Internalname = "vCCATEGORIADESCRIPCION" ;
         lblTextblocksubcategoriacodigo_Internalname = "TEXTBLOCKSUBCATEGORIACODIGO" ;
         edtavCsubcategoriacodigo_Internalname = "vCSUBCATEGORIACODIGO" ;
         lblTextblocksubcategoriadescripcion_Internalname = "TEXTBLOCKSUBCATEGORIADESCRIPCION" ;
         edtavCsubcategoriadescripcion_Internalname = "vCSUBCATEGORIADESCRIPCION" ;
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
         dynCategoriaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtSubCategoriaCodigo_Jsonclick = "" ;
         edtCategoriaDescripcion_Jsonclick = "" ;
         edtavCsubcategoriadescripcion_Jsonclick = "" ;
         edtavCsubcategoriacodigo_Jsonclick = "" ;
         edtavCcategoriadescripcion_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Sub-Categorías" ;
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
         wcpOAV9pClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         AV6cCategoriaDescripcion = "" ;
         AV7cSubCategoriaCodigo = "" ;
         AV8cSubCategoriaDescripcion = "" ;
         AV10pCategoriaCodigo = "" ;
         AV11pSubCategoriaCodigo = "" ;
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
         edtCategoriaDescripcion_Internalname = "" ;
         edtSubCategoriaCodigo_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         dynCategoriaCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A28CategoriaDescripcion = "" ;
         A124SubCategoriaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         A27CategoriaCodigo = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H003L2_A41ClinicaCodigo = new String[] {""} ;
         H003L2_A27CategoriaCodigo = new String[] {""} ;
         H003L2_A28CategoriaDescripcion = new String[] {""} ;
         H003L2_A29CategoriaEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         lV6cCategoriaDescripcion = "" ;
         lV7cSubCategoriaCodigo = "" ;
         lV8cSubCategoriaDescripcion = "" ;
         H003L3_A125SubCategoriaDescripcion = new String[] {""} ;
         H003L3_A27CategoriaCodigo = new String[] {""} ;
         H003L3_A41ClinicaCodigo = new String[] {""} ;
         H003L3_A124SubCategoriaCodigo = new String[] {""} ;
         H003L3_A28CategoriaDescripcion = new String[] {""} ;
         A125SubCategoriaDescripcion = "" ;
         H003L4_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char4 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockcategoriadescripcion_Jsonclick = "" ;
         lblTextblocksubcategoriacodigo_Jsonclick = "" ;
         lblTextblocksubcategoriadescripcion_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char5 = "" ;
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00b1__default(),
            new Object[][] {
                new Object[] {
               H003L2_A41ClinicaCodigo, H003L2_A27CategoriaCodigo, H003L2_A28CategoriaDescripcion, H003L2_A29CategoriaEstado
               }
               , new Object[] {
               H003L3_A125SubCategoriaDescripcion, H003L3_A27CategoriaCodigo, H003L3_A41ClinicaCodigo, H003L3_A124SubCategoriaCodigo, H003L3_A28CategoriaDescripcion
               }
               , new Object[] {
               H003L4_AGRID1_nRecordCount
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
      private int gxdynajaxindex ;
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
      private String edtCategoriaDescripcion_Internalname ;
      private String edtSubCategoriaCodigo_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String dynCategoriaCodigo_Internalname ;
      private String edtavCcategoriadescripcion_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCsubcategoriacodigo_Internalname ;
      private String edtavCsubcategoriadescripcion_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String GXt_char4 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockcategoriadescripcion_Internalname ;
      private String lblTextblockcategoriadescripcion_Jsonclick ;
      private String edtavCcategoriadescripcion_Jsonclick ;
      private String lblTextblocksubcategoriacodigo_Internalname ;
      private String lblTextblocksubcategoriacodigo_Jsonclick ;
      private String edtavCsubcategoriacodigo_Jsonclick ;
      private String lblTextblocksubcategoriadescripcion_Internalname ;
      private String lblTextblocksubcategoriadescripcion_Jsonclick ;
      private String edtavCsubcategoriadescripcion_Jsonclick ;
      private String GXt_char5 ;
      private String ROClassString ;
      private String edtCategoriaDescripcion_Jsonclick ;
      private String edtSubCategoriaCodigo_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String dynCategoriaCodigo_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV9pClinicaCodigo ;
      private String wcpOAV9pClinicaCodigo ;
      private String AV6cCategoriaDescripcion ;
      private String AV7cSubCategoriaCodigo ;
      private String AV8cSubCategoriaDescripcion ;
      private String AV10pCategoriaCodigo ;
      private String AV11pSubCategoriaCodigo ;
      private String A28CategoriaDescripcion ;
      private String A124SubCategoriaCodigo ;
      private String A41ClinicaCodigo ;
      private String A27CategoriaCodigo ;
      private String lV6cCategoriaDescripcion ;
      private String lV7cSubCategoriaCodigo ;
      private String lV8cSubCategoriaDescripcion ;
      private String A125SubCategoriaDescripcion ;
      private String AV5LinkSelection ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynCategoriaCodigo ;
      private IDataStoreProvider pr_default ;
      private String[] H003L2_A41ClinicaCodigo ;
      private String[] H003L2_A27CategoriaCodigo ;
      private String[] H003L2_A28CategoriaDescripcion ;
      private short[] H003L2_A29CategoriaEstado ;
      private String[] H003L3_A125SubCategoriaDescripcion ;
      private String[] H003L3_A27CategoriaCodigo ;
      private String[] H003L3_A41ClinicaCodigo ;
      private String[] H003L3_A124SubCategoriaCodigo ;
      private String[] H003L3_A28CategoriaDescripcion ;
      private int[] H003L4_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP1_pCategoriaCodigo ;
      private String aP2_pSubCategoriaCodigo ;
      private GXWebForm Form ;
   }

   public class gx00b1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003L2 ;
          prmH003L2 = new Object[] {
          } ;
          Object[] prmH003L3 ;
          prmH003L3 = new Object[] {
          new Object[] {"@AV9pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV6cCategoriaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV7cSubCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cSubCategoriaDescripcion",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH003L4 ;
          prmH003L4 = new Object[] {
          new Object[] {"@AV9pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV6cCategoriaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV7cSubCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cSubCategoriaDescripcion",SqlDbType.VarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003L2", "SELECT [ClinicaCodigo], [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado] FROM [Categoria] WITH (NOLOCK) WHERE [CategoriaEstado] = 1 ORDER BY [CategoriaDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003L2,0,0,true,false )
             ,new CursorDef("H003L3", "SELECT T1.[SubCategoriaDescripcion], T1.[CategoriaCodigo], T1.[ClinicaCodigo], T1.[SubCategoriaCodigo], T2.[CategoriaDescripcion] FROM ([SubCategoria] T1 WITH (NOLOCK) INNER JOIN [Categoria] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[CategoriaCodigo] = T1.[CategoriaCodigo]) WHERE (T1.[ClinicaCodigo] = @AV9pClinicaCodigo) AND (T2.[CategoriaDescripcion] like @lV6cCategoriaDescripcion) AND (T1.[SubCategoriaCodigo] like @lV7cSubCategoriaCodigo) AND (T1.[SubCategoriaDescripcion] like @lV8cSubCategoriaDescripcion) ORDER BY T1.[ClinicaCodigo], T1.[CategoriaCodigo], T1.[SubCategoriaCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003L3,11,0,true,false )
             ,new CursorDef("H003L4", "SELECT COUNT(*) FROM ([SubCategoria] T1 WITH (NOLOCK) INNER JOIN [Categoria] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[CategoriaCodigo] = T1.[CategoriaCodigo]) WHERE (T1.[ClinicaCodigo] = @AV9pClinicaCodigo) AND (T2.[CategoriaDescripcion] like @lV6cCategoriaDescripcion) AND (T1.[SubCategoriaCodigo] like @lV7cSubCategoriaCodigo) AND (T1.[SubCategoriaDescripcion] like @lV8cSubCategoriaDescripcion) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003L4,1,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
       }
    }

 }

}
