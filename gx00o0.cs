/*
               File: Gx00O0
        Description: Selection List Aseguradoras médicas
             Author: GeneXus C# Generator version 10_1_1-28290
       Generated on: 2/28/2019 16:41:4.80
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
   public class gx00o0 : GXDataArea
   {
      public gx00o0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00o0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_pAsegCodigo )
      {
         this.AV13pAsegCodigo = aP0_pAsegCodigo;
         executePrivate();
         aP0_pAsegCodigo=this.AV13pAsegCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbAsegEstado = new GXCombobox();
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
               GXCCtl = "ASEGESTADO_" + sGXsfl_51_idx ;
               cmbAsegEstado.Name = GXCCtl ;
               cmbAsegEstado.Height = 1 ;
               cmbAsegEstado.WebTags = "" ;
               cmbAsegEstado.addItem("0", "De baja", 0);
               cmbAsegEstado.addItem("1", "Activo", 0);
               if ( ( cmbAsegEstado.ItemCount > 0 ) && (0==A90AsegEstado) )
               {
                  A90AsegEstado = (short)(NumberUtil.Val( cmbAsegEstado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90AsegEstado", StringUtil.LTrim( StringUtil.Str( (decimal)(A90AsegEstado), 1, 0)));
               }
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cAsegCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsegCodigo", AV6cAsegCodigo);
               AV7cAsegNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsegNombre", AV7cAsegNombre);
               AV8cAsegDireccion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cAsegDireccion", AV8cAsegDireccion);
               AV9cAsegTelefono1 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsegTelefono1", AV9cAsegTelefono1);
               AV10cAsegTelefono2 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cAsegTelefono2", AV10cAsegTelefono2);
               AV11cAsegNit = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cAsegNit", AV11cAsegNit);
               AV12cAsegContacto = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegContacto", AV12cAsegContacto);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cAsegCodigo, AV7cAsegNombre, AV8cAsegDireccion, AV9cAsegTelefono1, AV10cAsegTelefono2, AV11cAsegNit, AV12cAsegContacto) ;
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
               AV13pAsegCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pAsegCodigo", AV13pAsegCodigo);
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
         context.DoAfterInit();
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
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA0U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0U2( ) ;
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
            context.AddJavascriptSource("gxgral.js", "?28290");
            context.AddJavascriptSource("gxcfg.js", "?28290");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?28290");
            context.AddJavascriptSource("gxfxSD.js", "?28290");
            context.AddJavascriptSource("gxtypesSD.js", "?28290");
            context.AddJavascriptSource("gxpopupSD.js", "?28290");
            context.AddJavascriptSource("gxfrmutlSD.js", "?28290");
            context.AddJavascriptSource("gxgridSD.js", "?28290");
            context.AddJavascriptSource("JavaScripTableSD.js", "?28290");
            context.AddJavascriptSource("rijndaelSD.js", "?28290");
            context.AddJavascriptSource("gxgralSD.js", "?28290");
            context.AddJavascriptSource("gxcfg.js", "?28290");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"bottommargin=\"0\""+" "+"topmargin=\"0\""+" "+"marginheight=\"0\""+" "+"leftmargin=\"0\""+" "+"marginwidth=\"0\""+" "+"class=\"Form\""+" "+"rightmargin=\"0\""+" "+" style=\"-moz-opacity: 0;opacity: 0;\" "+" bgcolor=\""+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" action=\""+formatLink("gx00o0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pAsegCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH__CASEGCODIGO", StringUtil.RTrim( AV6cAsegCodigo));
         GxWebStd.gx_hidden_field( context, "GXH__CASEGNOMBRE", StringUtil.RTrim( AV7cAsegNombre));
         GxWebStd.gx_hidden_field( context, "GXH__CASEGDIRECCION", StringUtil.RTrim( AV8cAsegDireccion));
         GxWebStd.gx_hidden_field( context, "GXH__CASEGTELEFONO1", StringUtil.RTrim( AV9cAsegTelefono1));
         GxWebStd.gx_hidden_field( context, "GXH__CASEGTELEFONO2", StringUtil.RTrim( AV10cAsegTelefono2));
         GxWebStd.gx_hidden_field( context, "GXH__CASEGNIT", StringUtil.RTrim( AV11cAsegNit));
         GxWebStd.gx_hidden_field( context, "GXH__CASEGCONTACTO", StringUtil.RTrim( AV12cAsegContacto));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         GxWebStd.gx_hidden_field( context, "_PASEGCODIGO", StringUtil.RTrim( AV13pAsegCodigo));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
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
            WE0U2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00O0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Aseguradoras médicas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00o0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pAsegCodigo)) ;
      }

      protected void WB0U0( )
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
            wb_table1_2_0U2( true) ;
         }
         else
         {
            wb_table1_2_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0U2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_1-28290", 0) ;
         Form.Meta.addItem("Description", "Selection List Aseguradoras médicas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            context.sCallerURL = cgiGet( "sCallerURL") ;
         }
         else
         {
            context.sCallerURL = context.GetReferer( ) ;
         }
         wbErr = false ;
         STRUP0U0( ) ;
      }

      protected void WS0U2( )
      {
         START0U2( ) ;
         EVT0U2( ) ;
      }

      protected void EVT0U2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGCODIGO"), AV6cAsegCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGNOMBRE"), AV7cAsegNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGDIRECCION"), AV8cAsegDireccion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGTELEFONO1"), AV9cAsegTelefono1) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGTELEFONO2"), AV10cAsegTelefono2) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGNIT"), AV11cAsegNit) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGCONTACTO"), AV12cAsegContacto) != 0 )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_51_idx ;
                              edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
                              edtAsegNombre_Internalname = "ASEGNOMBRE_"+sGXsfl_51_idx ;
                              edtAsegTelefono1_Internalname = "ASEGTELEFONO1_"+sGXsfl_51_idx ;
                              edtAsegTelefono2_Internalname = "ASEGTELEFONO2_"+sGXsfl_51_idx ;
                              edtAsegNit_Internalname = "ASEGNIT_"+sGXsfl_51_idx ;
                              cmbAsegEstado_Internalname = "ASEGESTADO_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A82AsegCodigo = cgiGet( edtAsegCodigo_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
                              A83AsegNombre = cgiGet( edtAsegNombre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83AsegNombre", A83AsegNombre);
                              A85AsegTelefono1 = cgiGet( edtAsegTelefono1_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85AsegTelefono1", A85AsegTelefono1);
                              A86AsegTelefono2 = cgiGet( edtAsegTelefono2_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86AsegTelefono2", A86AsegTelefono2);
                              A87AsegNit = cgiGet( edtAsegNit_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87AsegNit", A87AsegNit);
                              cmbAsegEstado.Name = cmbAsegEstado_Internalname ;
                              cmbAsegEstado.CurrentValue = cgiGet( cmbAsegEstado_Internalname) ;
                              A90AsegEstado = (short)(NumberUtil.Val( cgiGet( cmbAsegEstado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90AsegEstado", StringUtil.LTrim( StringUtil.Str( (decimal)(A90AsegEstado), 1, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110U2 */
                                    E110U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120U2 */
                                    E120U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Casegcodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGCODIGO"), AV6cAsegCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGNOMBRE"), AV7cAsegNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegdireccion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGDIRECCION"), AV8cAsegDireccion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegtelefono1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGTELEFONO1"), AV9cAsegTelefono1) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegtelefono2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGTELEFONO2"), AV10cAsegTelefono2) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegnit Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGNIT"), AV11cAsegNit) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegcontacto Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH__CASEGCONTACTO"), AV12cAsegContacto) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130U2 */
                                          E130U2 ();
                                       }
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

      protected void WE0U2( )
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

      protected void PA0U2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "ASEGESTADO_" + sGXsfl_51_idx ;
            cmbAsegEstado.Name = GXCCtl ;
            cmbAsegEstado.Height = 1 ;
            cmbAsegEstado.WebTags = "" ;
            cmbAsegEstado.addItem("0", "De baja", 0);
            cmbAsegEstado.addItem("1", "Activo", 0);
            if ( ( cmbAsegEstado.ItemCount > 0 ) && (0==A90AsegEstado) )
            {
               A90AsegEstado = (short)(NumberUtil.Val( cmbAsegEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90AsegEstado", StringUtil.LTrim( StringUtil.Str( (decimal)(A90AsegEstado), 1, 0)));
            }
            GX_FocusControl = edtavCasegcodigo_Internalname ;
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
         edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_51_idx ;
         edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
         edtAsegNombre_Internalname = "ASEGNOMBRE_"+sGXsfl_51_idx ;
         edtAsegTelefono1_Internalname = "ASEGTELEFONO1_"+sGXsfl_51_idx ;
         edtAsegTelefono2_Internalname = "ASEGTELEFONO2_"+sGXsfl_51_idx ;
         edtAsegNit_Internalname = "ASEGNIT_"+sGXsfl_51_idx ;
         cmbAsegEstado_Internalname = "ASEGESTADO_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_51_idx ;
            edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
            edtAsegNombre_Internalname = "ASEGNOMBRE_"+sGXsfl_51_idx ;
            edtAsegTelefono1_Internalname = "ASEGTELEFONO1_"+sGXsfl_51_idx ;
            edtAsegTelefono2_Internalname = "ASEGTELEFONO2_"+sGXsfl_51_idx ;
            edtAsegNit_Internalname = "ASEGNIT_"+sGXsfl_51_idx ;
            cmbAsegEstado_Internalname = "ASEGESTADO_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cAsegCodigo ,
                                        String AV7cAsegNombre ,
                                        String AV8cAsegDireccion ,
                                        String AV9cAsegTelefono1 ,
                                        String AV10cAsegTelefono2 ,
                                        String AV11cAsegNit ,
                                        String AV12cAsegContacto )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF0U2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0U2( ) ;
         /* End function Refresh */
      }

      protected void RF0U2( )
      {
         Grid1Container.Clear();
         Grid1Container.SetWrapped(nGXWrapped);
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_51_idx ;
         edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
         edtAsegNombre_Internalname = "ASEGNOMBRE_"+sGXsfl_51_idx ;
         edtAsegTelefono1_Internalname = "ASEGTELEFONO1_"+sGXsfl_51_idx ;
         edtAsegTelefono2_Internalname = "ASEGTELEFONO2_"+sGXsfl_51_idx ;
         edtAsegNit_Internalname = "ASEGNIT_"+sGXsfl_51_idx ;
         cmbAsegEstado_Internalname = "ASEGESTADO_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            lV6cAsegCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cAsegCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsegCodigo", AV6cAsegCodigo);
            lV7cAsegNombre = StringUtil.PadR( StringUtil.RTrim( AV7cAsegNombre), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsegNombre", AV7cAsegNombre);
            lV8cAsegDireccion = StringUtil.PadR( StringUtil.RTrim( AV8cAsegDireccion), 80, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cAsegDireccion", AV8cAsegDireccion);
            lV9cAsegTelefono1 = StringUtil.PadR( StringUtil.RTrim( AV9cAsegTelefono1), 9, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsegTelefono1", AV9cAsegTelefono1);
            lV10cAsegTelefono2 = StringUtil.PadR( StringUtil.RTrim( AV10cAsegTelefono2), 9, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cAsegTelefono2", AV10cAsegTelefono2);
            lV11cAsegNit = StringUtil.PadR( StringUtil.RTrim( AV11cAsegNit), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cAsegNit", AV11cAsegNit);
            lV12cAsegContacto = StringUtil.PadR( StringUtil.RTrim( AV12cAsegContacto), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegContacto", AV12cAsegContacto);
            /* Using cursor H000U2 */
            pr_default.execute(0, new Object[] {lV6cAsegCodigo, lV7cAsegNombre, lV8cAsegDireccion, lV9cAsegTelefono1, lV10cAsegTelefono2, lV11cAsegNit, lV12cAsegContacto});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A84AsegDireccion = H000U2_A84AsegDireccion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84AsegDireccion", A84AsegDireccion);
               A88AsegContacto = H000U2_A88AsegContacto[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88AsegContacto", A88AsegContacto);
               A90AsegEstado = H000U2_A90AsegEstado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90AsegEstado", StringUtil.LTrim( StringUtil.Str( (decimal)(A90AsegEstado), 1, 0)));
               A87AsegNit = H000U2_A87AsegNit[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87AsegNit", A87AsegNit);
               A86AsegTelefono2 = H000U2_A86AsegTelefono2[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86AsegTelefono2", A86AsegTelefono2);
               A85AsegTelefono1 = H000U2_A85AsegTelefono1[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85AsegTelefono1", A85AsegTelefono1);
               A83AsegNombre = H000U2_A83AsegNombre[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83AsegNombre", A83AsegNombre);
               A82AsegCodigo = H000U2_A82AsegCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
               /* Execute user event: E120U2 */
               E120U2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB0U0( ) ;
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
         lV6cAsegCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cAsegCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsegCodigo", AV6cAsegCodigo);
         lV7cAsegNombre = StringUtil.PadR( StringUtil.RTrim( AV7cAsegNombre), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsegNombre", AV7cAsegNombre);
         lV8cAsegDireccion = StringUtil.PadR( StringUtil.RTrim( AV8cAsegDireccion), 80, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cAsegDireccion", AV8cAsegDireccion);
         lV9cAsegTelefono1 = StringUtil.PadR( StringUtil.RTrim( AV9cAsegTelefono1), 9, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsegTelefono1", AV9cAsegTelefono1);
         lV10cAsegTelefono2 = StringUtil.PadR( StringUtil.RTrim( AV10cAsegTelefono2), 9, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cAsegTelefono2", AV10cAsegTelefono2);
         lV11cAsegNit = StringUtil.PadR( StringUtil.RTrim( AV11cAsegNit), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cAsegNit", AV11cAsegNit);
         lV12cAsegContacto = StringUtil.PadR( StringUtil.RTrim( AV12cAsegContacto), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegContacto", AV12cAsegContacto);
         /* Using cursor H000U3 */
         pr_default.execute(1, new Object[] {lV6cAsegCodigo, lV7cAsegNombre, lV8cAsegDireccion, lV9cAsegTelefono1, lV10cAsegTelefono2, lV11cAsegNit, lV12cAsegContacto});
         GRID1_nRecordCount = H000U3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP0U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110U2 */
         E110U2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cAsegCodigo = cgiGet( edtavCasegcodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsegCodigo", AV6cAsegCodigo);
            AV7cAsegNombre = cgiGet( edtavCasegnombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsegNombre", AV7cAsegNombre);
            AV8cAsegDireccion = cgiGet( edtavCasegdireccion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cAsegDireccion", AV8cAsegDireccion);
            AV9cAsegTelefono1 = cgiGet( edtavCasegtelefono1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsegTelefono1", AV9cAsegTelefono1);
            AV10cAsegTelefono2 = cgiGet( edtavCasegtelefono2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cAsegTelefono2", AV10cAsegTelefono2);
            AV11cAsegNit = cgiGet( edtavCasegnit_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cAsegNit", AV11cAsegNit);
            AV12cAsegContacto = cgiGet( edtavCasegcontacto_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegContacto", AV12cAsegContacto);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            context.sCallerURL = cgiGet( "sCallerURL") ;
            AV13pAsegCodigo = cgiGet( "_PASEGCODIGO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
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
         /* Execute user event: E110U2 */
         E110U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110U2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Aseguradoras médicas", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120U2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E130U2 */
         E130U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130U2( )
      {
         /* Enter Routine */
         AV13pAsegCodigo = A82AsegCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pAsegCodigo", AV13pAsegCodigo);
         context.setWebReturnParms(new Object[] {(String)AV13pAsegCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+" "+"align=\""+"center"+"\""+" "+">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset name=\""+grpGroup1_Internalname+"\""+" id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_0U2( true) ;
         }
         else
         {
            wb_table2_9_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset name=\""+grpGroup2_Internalname+"\""+" id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_48_0U2( true) ;
         }
         else
         {
            wb_table3_48_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0U2e( true) ;
         }
         else
         {
            wb_table1_2_0U2e( false) ;
         }
      }

      protected void wb_table3_48_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+" "+"colspan=\""+"3"+"\""+" "+">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( nGXWrapped == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "all", 0);
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
               context.WriteHtmlText( "<th align=\""+""+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Aseguradora") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Aseguradora") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Teléfono_1") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Teléfono_2") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Nit") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A82AsegCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A83AsegNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtAsegNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A85AsegTelefono1));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A86AsegTelefono2));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A87AsegNit));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A90AsegEstado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div"+"\" cmpCtx="+"''"+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+" "+"align=\""+"right"+"\""+" "+">") ;
            wb_table4_61_0U2( true) ;
         }
         else
         {
            wb_table4_61_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table4_61_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_0U2e( true) ;
         }
         else
         {
            wb_table3_48_0U2e( false) ;
         }
      }

      protected void wb_table4_61_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "64" + "," + "''" + "," + "false" + ",'" + "" + "'," + "51" + ")\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "standard", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_61_0U2e( true) ;
         }
         else
         {
            wb_table4_61_0U2e( false) ;
         }
      }

      protected void wb_table2_9_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegcodigo_Internalname, 1, 1, 0, "Aseguradora", "", "", "", 0, lblTextblockasegcodigo_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "14" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegcodigo_Internalname, StringUtil.RTrim( AV6cAsegCodigo), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6cAsegCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", 0, edtavCasegcodigo_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegnombre_Internalname, 1, 1, 0, "Aseguradora", "", "", "", 0, lblTextblockasegnombre_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "19" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegnombre_Internalname, StringUtil.RTrim( AV7cAsegNombre), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cAsegNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", 0, edtavCasegnombre_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegdireccion_Internalname, 1, 1, 0, "Dirección", "", "", "", 0, lblTextblockasegdireccion_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "24" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegdireccion_Internalname, StringUtil.RTrim( AV8cAsegDireccion), "", 80, "chr", 1, "row", 80, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cAsegDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCasegdireccion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegtelefono1_Internalname, 1, 1, 0, "Teléfono_1", "", "", "", 0, lblTextblockasegtelefono1_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "29" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegtelefono1_Internalname, StringUtil.RTrim( AV9cAsegTelefono1), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9cAsegTelefono1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavCasegtelefono1_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegtelefono2_Internalname, 1, 1, 0, "Teléfono_2", "", "", "", 0, lblTextblockasegtelefono2_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "34" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegtelefono2_Internalname, StringUtil.RTrim( AV10cAsegTelefono2), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10cAsegTelefono2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavCasegtelefono2_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegnit_Internalname, 1, 1, 0, "Nit", "", "", "", 0, lblTextblockasegnit_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "39" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegnit_Internalname, StringUtil.RTrim( AV11cAsegNit), "", 20, "chr", 1, "row", 20, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11cAsegNit, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", 0, edtavCasegnit_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegcontacto_Internalname, 1, 1, 0, "Contacto", "", "", "", 0, lblTextblockasegcontacto_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "44" + "," + "''" + "," + "false" + ",'" + sGXsfl_51_idx + "'," + "51" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegcontacto_Internalname, StringUtil.RTrim( AV12cAsegContacto), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV12cAsegContacto, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", 0, edtavCasegcontacto_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0U2e( true) ;
         }
         else
         {
            wb_table2_9_0U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pAsegCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pAsegCodigo", AV13pAsegCodigo);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         PA0U2( ) ;
         WS0U2( ) ;
         WE0U2( ) ;
         this.cleanup();
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?1634658");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1641544");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?28290");
         context.AddJavascriptSource("gx00o0.js", "?1641545");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB0U0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,nGXWrapped) ;
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
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+((subGrid1_Backcolorstyle==0) ? "background:transparent;" : "")+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A82AsegCodigo))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Fantastic",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsegCodigo_Internalname,StringUtil.RTrim( A82AsegCodigo),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A82AsegCodigo, "")),(String)"",(short)0,(String)edtAsegCodigo_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            edtAsegNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A82AsegCodigo))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsegNombre_Internalname, "Link", edtAsegNombre_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsegNombre_Internalname,StringUtil.RTrim( A83AsegNombre),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtAsegNombre_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A83AsegNombre, "")),(String)"",(short)0,(String)edtAsegNombre_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsegTelefono1_Internalname,StringUtil.RTrim( A85AsegTelefono1),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)9,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A85AsegTelefono1, "")),(String)"",(short)0,(String)edtAsegTelefono1_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsegTelefono2_Internalname,StringUtil.RTrim( A86AsegTelefono2),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)9,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A86AsegTelefono2, "")),(String)"",(short)0,(String)edtAsegTelefono2_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsegNit_Internalname,StringUtil.RTrim( A87AsegNit),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A87AsegNit, "")),(String)"",(short)0,(String)edtAsegNit_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "ASEGESTADO_" + sGXsfl_51_idx ;
               cmbAsegEstado.Name = GXCCtl ;
               cmbAsegEstado.Height = 1 ;
               cmbAsegEstado.WebTags = "" ;
               cmbAsegEstado.addItem("0", "De baja", 0);
               cmbAsegEstado.addItem("1", "Activo", 0);
               if ( ( cmbAsegEstado.ItemCount > 0 ) && (0==A90AsegEstado) )
               {
                  A90AsegEstado = (short)(NumberUtil.Val( cmbAsegEstado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90AsegEstado", StringUtil.LTrim( StringUtil.Str( (decimal)(A90AsegEstado), 1, 0)));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbAsegEstado,(String)cmbAsegEstado_Internalname,StringUtil.Str( (decimal)(A90AsegEstado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbAsegEstado_Jsonclick,(String)"",(String)"",(bool)true});
            cmbAsegEstado.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A90AsegEstado), 1, 0)) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbAsegEstado_Internalname, "Values", (String)(cmbAsegEstado.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_51_idx ;
            edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
            edtAsegNombre_Internalname = "ASEGNOMBRE_"+sGXsfl_51_idx ;
            edtAsegTelefono1_Internalname = "ASEGTELEFONO1_"+sGXsfl_51_idx ;
            edtAsegTelefono2_Internalname = "ASEGTELEFONO2_"+sGXsfl_51_idx ;
            edtAsegNit_Internalname = "ASEGNIT_"+sGXsfl_51_idx ;
            cmbAsegEstado_Internalname = "ASEGESTADO_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      public override void initialize_properties( )
      {
         lblTextblockasegcodigo_Internalname = "TEXTBLOCKASEGCODIGO" ;
         edtavCasegcodigo_Internalname = "_CASEGCODIGO" ;
         lblTextblockasegnombre_Internalname = "TEXTBLOCKASEGNOMBRE" ;
         edtavCasegnombre_Internalname = "_CASEGNOMBRE" ;
         lblTextblockasegdireccion_Internalname = "TEXTBLOCKASEGDIRECCION" ;
         edtavCasegdireccion_Internalname = "_CASEGDIRECCION" ;
         lblTextblockasegtelefono1_Internalname = "TEXTBLOCKASEGTELEFONO1" ;
         edtavCasegtelefono1_Internalname = "_CASEGTELEFONO1" ;
         lblTextblockasegtelefono2_Internalname = "TEXTBLOCKASEGTELEFONO2" ;
         edtavCasegtelefono2_Internalname = "_CASEGTELEFONO2" ;
         lblTextblockasegnit_Internalname = "TEXTBLOCKASEGNIT" ;
         edtavCasegnit_Internalname = "_CASEGNIT" ;
         lblTextblockasegcontacto_Internalname = "TEXTBLOCKASEGCONTACTO" ;
         edtavCasegcontacto_Internalname = "_CASEGCONTACTO" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
         cmbAsegEstado_Jsonclick = "" ;
         edtAsegNit_Jsonclick = "" ;
         edtAsegTelefono2_Jsonclick = "" ;
         edtAsegTelefono1_Jsonclick = "" ;
         edtAsegNombre_Jsonclick = "" ;
         edtAsegCodigo_Jsonclick = "" ;
         subGrid1_Backstyle = 1 ;
         edtavCasegcontacto_Jsonclick = "" ;
         edtavCasegnit_Jsonclick = "" ;
         edtavCasegtelefono2_Jsonclick = "" ;
         edtavCasegtelefono1_Jsonclick = "" ;
         edtavCasegdireccion_Jsonclick = "" ;
         edtavCasegnombre_Jsonclick = "" ;
         edtavCasegcodigo_Jsonclick = "" ;
         edtAsegNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Titlebackstyle = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Aseguradoras médicas" ;
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
         wcpOAV13pAsegCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         AV6cAsegCodigo = "" ;
         AV7cAsegNombre = "" ;
         AV8cAsegDireccion = "" ;
         AV9cAsegTelefono1 = "" ;
         AV10cAsegTelefono2 = "" ;
         AV11cAsegNit = "" ;
         AV12cAsegContacto = "" ;
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
         edtAsegCodigo_Internalname = "" ;
         edtAsegNombre_Internalname = "" ;
         edtAsegTelefono1_Internalname = "" ;
         edtAsegTelefono2_Internalname = "" ;
         edtAsegNit_Internalname = "" ;
         cmbAsegEstado_Internalname = "" ;
         AV5LinkSelection = "" ;
         A82AsegCodigo = "" ;
         A83AsegNombre = "" ;
         A85AsegTelefono1 = "" ;
         A86AsegTelefono2 = "" ;
         A87AsegNit = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cAsegCodigo = "" ;
         lV7cAsegNombre = "" ;
         lV8cAsegDireccion = "" ;
         lV9cAsegTelefono1 = "" ;
         lV10cAsegTelefono2 = "" ;
         lV11cAsegNit = "" ;
         lV12cAsegContacto = "" ;
         H000U2_A84AsegDireccion = new String[] {""} ;
         H000U2_A88AsegContacto = new String[] {""} ;
         H000U2_A90AsegEstado = new short[1] ;
         H000U2_A87AsegNit = new String[] {""} ;
         H000U2_A86AsegTelefono2 = new String[] {""} ;
         H000U2_A85AsegTelefono1 = new String[] {""} ;
         H000U2_A83AsegNombre = new String[] {""} ;
         H000U2_A82AsegCodigo = new String[] {""} ;
         A84AsegDireccion = "" ;
         A88AsegContacto = "" ;
         H000U3_AGRID1_nRecordCount = new int[1] ;
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
         lblTextblockasegcodigo_Jsonclick = "" ;
         lblTextblockasegnombre_Jsonclick = "" ;
         lblTextblockasegdireccion_Jsonclick = "" ;
         lblTextblockasegtelefono1_Jsonclick = "" ;
         lblTextblockasegtelefono2_Jsonclick = "" ;
         lblTextblockasegnit_Jsonclick = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         lblTextblockasegcontacto_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00o0__default(),
            new Object[][] {
                new Object[] {
               H000U2_A84AsegDireccion, H000U2_A88AsegContacto, H000U2_A90AsegEstado, H000U2_A87AsegNit, H000U2_A86AsegTelefono2, H000U2_A85AsegTelefono1, H000U2_A83AsegNombre, H000U2_A82AsegCodigo
               }
               , new Object[] {
               H000U3_AGRID1_nRecordCount
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
      private short A90AsegEstado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
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
      private String sGXsfl_51_idx="0001" ;
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
      private String edtAsegCodigo_Internalname ;
      private String edtAsegNombre_Internalname ;
      private String edtAsegTelefono1_Internalname ;
      private String edtAsegTelefono2_Internalname ;
      private String edtAsegNit_Internalname ;
      private String cmbAsegEstado_Internalname ;
      private String edtavCasegcodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCasegnombre_Internalname ;
      private String edtavCasegdireccion_Internalname ;
      private String edtavCasegtelefono1_Internalname ;
      private String edtavCasegtelefono2_Internalname ;
      private String edtavCasegnit_Internalname ;
      private String edtavCasegcontacto_Internalname ;
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
      private String edtAsegNombre_Link ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockasegcodigo_Internalname ;
      private String lblTextblockasegcodigo_Jsonclick ;
      private String edtavCasegcodigo_Jsonclick ;
      private String lblTextblockasegnombre_Internalname ;
      private String lblTextblockasegnombre_Jsonclick ;
      private String edtavCasegnombre_Jsonclick ;
      private String lblTextblockasegdireccion_Internalname ;
      private String lblTextblockasegdireccion_Jsonclick ;
      private String edtavCasegdireccion_Jsonclick ;
      private String lblTextblockasegtelefono1_Internalname ;
      private String lblTextblockasegtelefono1_Jsonclick ;
      private String edtavCasegtelefono1_Jsonclick ;
      private String lblTextblockasegtelefono2_Internalname ;
      private String lblTextblockasegtelefono2_Jsonclick ;
      private String edtavCasegtelefono2_Jsonclick ;
      private String lblTextblockasegnit_Internalname ;
      private String lblTextblockasegnit_Jsonclick ;
      private String edtavCasegnit_Jsonclick ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String lblTextblockasegcontacto_Internalname ;
      private String lblTextblockasegcontacto_Jsonclick ;
      private String edtavCasegcontacto_Jsonclick ;
      private String ROClassString ;
      private String edtAsegCodigo_Jsonclick ;
      private String edtAsegNombre_Jsonclick ;
      private String edtAsegTelefono1_Jsonclick ;
      private String edtAsegTelefono2_Jsonclick ;
      private String edtAsegNit_Jsonclick ;
      private String cmbAsegEstado_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV13pAsegCodigo ;
      private String wcpOAV13pAsegCodigo ;
      private String AV6cAsegCodigo ;
      private String AV7cAsegNombre ;
      private String AV8cAsegDireccion ;
      private String AV9cAsegTelefono1 ;
      private String AV10cAsegTelefono2 ;
      private String AV11cAsegNit ;
      private String AV12cAsegContacto ;
      private String A82AsegCodigo ;
      private String A83AsegNombre ;
      private String A85AsegTelefono1 ;
      private String A86AsegTelefono2 ;
      private String A87AsegNit ;
      private String lV6cAsegCodigo ;
      private String lV7cAsegNombre ;
      private String lV8cAsegDireccion ;
      private String lV9cAsegTelefono1 ;
      private String lV10cAsegTelefono2 ;
      private String lV11cAsegNit ;
      private String lV12cAsegContacto ;
      private String A84AsegDireccion ;
      private String A88AsegContacto ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_pAsegCodigo ;
      private GXCombobox cmbAsegEstado ;
      private IDataStoreProvider pr_default ;
      private String[] H000U2_A84AsegDireccion ;
      private String[] H000U2_A88AsegContacto ;
      private short[] H000U2_A90AsegEstado ;
      private String[] H000U2_A87AsegNit ;
      private String[] H000U2_A86AsegTelefono2 ;
      private String[] H000U2_A85AsegTelefono1 ;
      private String[] H000U2_A83AsegNombre ;
      private String[] H000U2_A82AsegCodigo ;
      private int[] H000U3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class gx00o0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000U2 ;
          prmH000U2 = new Object[] {
          new Object[] {"@AV6cAsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cAsegNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV8cAsegDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV9cAsegTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV10cAsegTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV11cAsegNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV12cAsegContacto",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH000U3 ;
          prmH000U3 = new Object[] {
          new Object[] {"@AV6cAsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cAsegNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV8cAsegDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV9cAsegTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV10cAsegTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV11cAsegNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV12cAsegContacto",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000U2", "SELECT [AsegDireccion], [AsegContacto], [AsegEstado], [AsegNit], [AsegTelefono2], [AsegTelefono1], [AsegNombre], [AsegCodigo] FROM [Aseguradora] WITH (NOLOCK) WHERE ([AsegCodigo] like @AV6cAsegCodigo) AND ([AsegNombre] like @AV7cAsegNombre) AND ([AsegDireccion] like @AV8cAsegDireccion) AND ([AsegTelefono1] like @AV9cAsegTelefono1) AND ([AsegTelefono2] like @AV10cAsegTelefono2) AND ([AsegNit] like @AV11cAsegNit) AND ([AsegContacto] like @AV12cAsegContacto) ORDER BY [AsegCodigo]  OPTION (FAST 1)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U2,11,0,false,false )
             ,new CursorDef("H000U3", "SELECT COUNT(*) FROM [Aseguradora] WITH (NOLOCK) WHERE ([AsegCodigo] like @AV6cAsegCodigo) AND ([AsegNombre] like @AV7cAsegNombre) AND ([AsegDireccion] like @AV8cAsegDireccion) AND ([AsegTelefono1] like @AV9cAsegTelefono1) AND ([AsegTelefono2] like @AV10cAsegTelefono2) AND ([AsegNit] like @AV11cAsegNit) AND ([AsegContacto] like @AV12cAsegContacto) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U3,1,0,false,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
