/*
               File: Gx0020
        Description: Selection List Usuarios
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:23.2
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
   public class gx0020 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx0020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pUsuarioCodigo )
      {
         this.AV12pUsuarioCodigo = "" ;
         executePrivate();
         aP0_pUsuarioCodigo=this.AV12pUsuarioCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCusuarioestado = new GXCombobox();
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
               cmbavCusuarioestado.Name = "vCUSUARIOESTADO" ;
               cmbavCusuarioestado.WebTags = "" ;
               cmbavCusuarioestado.addItem("0", "De baja", 0);
               cmbavCusuarioestado.addItem("1", "Activo", 0);
               if ( ( cmbavCusuarioestado.ItemCount > 0 ) && (0==AV10cUsuarioEstado) )
               {
                  AV10cUsuarioEstado = (short)(NumberUtil.Val( cmbavCusuarioestado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioEstado", StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0));
               }
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cUsuarioCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioCodigo", AV6cUsuarioCodigo);
               AV7cUsuarioNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioNombre", AV7cUsuarioNombre);
               AV8cUsuarioContrasena = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioContrasena", AV8cUsuarioContrasena);
               AV9cGrupoCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupoCodigo", AV9cGrupoCodigo);
               AV10cUsuarioEstado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioEstado", StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0));
               AV11cUsuarioCorreo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCorreo", AV11cUsuarioCorreo);
               AV13cUsuarioTelefono = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cUsuarioTelefono", AV13cUsuarioTelefono);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cUsuarioCodigo, AV7cUsuarioNombre, AV8cUsuarioContrasena, AV9cGrupoCodigo, AV10cUsuarioEstado, AV11cUsuarioCorreo, AV13cUsuarioTelefono) ;
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
               AV12pUsuarioCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuarioCodigo", AV12pUsuarioCodigo);
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
         PA092( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START092( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0020.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pUsuarioCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOCODIGO", StringUtil.RTrim( AV6cUsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIONOMBRE", StringUtil.RTrim( AV7cUsuarioNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOCONTRASENA", StringUtil.RTrim( AV8cUsuarioContrasena));
         GxWebStd.gx_hidden_field( context, "GXH_vCGRUPOCODIGO", StringUtil.RTrim( AV9cGrupoCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cUsuarioEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOCORREO", StringUtil.RTrim( AV11cUsuarioCorreo));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOTELEFONO", StringUtil.RTrim( AV13cUsuarioTelefono));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPUSUARIOCODIGO", StringUtil.RTrim( AV12pUsuarioCodigo));
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
            WE092( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT092( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0020" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Usuarios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0020.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pUsuarioCodigo)) ;
      }

      protected void WB090( )
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
            wb_table1_2_092( true) ;
         }
         else
         {
            wb_table1_2_092( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_092e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START092( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Usuarios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP090( ) ;
      }

      protected void WS092( )
      {
         START092( ) ;
         EVT092( ) ;
      }

      protected void EVT092( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCODIGO"), AV6cUsuarioCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIONOMBRE"), AV7cUsuarioNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCONTRASENA"), AV8cUsuarioContrasena) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPOCODIGO"), AV9cGrupoCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOESTADO"), ".", ",") != Convert.ToDecimal( AV10cUsuarioEstado )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCORREO"), AV11cUsuarioCorreo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOTELEFONO"), AV13cUsuarioTelefono) != 0 )
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
                              edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
                              edtUsuarioNombre_Internalname = "USUARIONOMBRE_"+sGXsfl_51_idx ;
                              edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA_"+sGXsfl_51_idx ;
                              edtUsuarioFoto_Internalname = "USUARIOFOTO_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
                              A5UsuarioNombre = cgiGet( edtUsuarioNombre_Internalname) ;
                              A6UsuarioContrasena = cgiGet( edtUsuarioContrasena_Internalname) ;
                              A52UsuarioFoto = cgiGet( edtUsuarioFoto_Internalname) ;
                              n52UsuarioFoto = false ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11092 */
                                    E11092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12092 */
                                    E12092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cusuariocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCODIGO"), AV6cUsuarioCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cusuarionombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIONOMBRE"), AV7cUsuarioNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cusuariocontrasena Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCONTRASENA"), AV8cUsuarioContrasena) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgrupocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPOCODIGO"), AV9cGrupoCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cusuarioestado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOESTADO"), ".", ",") != Convert.ToDecimal( AV10cUsuarioEstado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cusuariocorreo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCORREO"), AV11cUsuarioCorreo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cusuariotelefono Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOTELEFONO"), AV13cUsuarioTelefono) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13092 */
                                          E13092 ();
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

      protected void WE092( )
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

      protected void PA092( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCusuarioestado.Name = "vCUSUARIOESTADO" ;
            cmbavCusuarioestado.WebTags = "" ;
            cmbavCusuarioestado.addItem("0", "De baja", 0);
            cmbavCusuarioestado.addItem("1", "Activo", 0);
            if ( ( cmbavCusuarioestado.ItemCount > 0 ) && (0==AV10cUsuarioEstado) )
            {
               AV10cUsuarioEstado = (short)(NumberUtil.Val( cmbavCusuarioestado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioEstado", StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0));
            }
            GX_FocusControl = edtavCusuariocodigo_Internalname ;
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
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
         edtUsuarioNombre_Internalname = "USUARIONOMBRE_"+sGXsfl_51_idx ;
         edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA_"+sGXsfl_51_idx ;
         edtUsuarioFoto_Internalname = "USUARIOFOTO_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
            edtUsuarioNombre_Internalname = "USUARIONOMBRE_"+sGXsfl_51_idx ;
            edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA_"+sGXsfl_51_idx ;
            edtUsuarioFoto_Internalname = "USUARIOFOTO_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cUsuarioCodigo ,
                                        String AV7cUsuarioNombre ,
                                        String AV8cUsuarioContrasena ,
                                        String AV9cGrupoCodigo ,
                                        short AV10cUsuarioEstado ,
                                        String AV11cUsuarioCorreo ,
                                        String AV13cUsuarioTelefono )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF092( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF092( ) ;
         /* End function Refresh */
      }

      protected void RF092( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
         edtUsuarioNombre_Internalname = "USUARIONOMBRE_"+sGXsfl_51_idx ;
         edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA_"+sGXsfl_51_idx ;
         edtUsuarioFoto_Internalname = "USUARIOFOTO_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
            edtUsuarioNombre_Internalname = "USUARIONOMBRE_"+sGXsfl_51_idx ;
            edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA_"+sGXsfl_51_idx ;
            edtUsuarioFoto_Internalname = "USUARIOFOTO_"+sGXsfl_51_idx ;
            lV6cUsuarioCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cUsuarioCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioCodigo", AV6cUsuarioCodigo);
            lV7cUsuarioNombre = StringUtil.PadR( StringUtil.RTrim( AV7cUsuarioNombre), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioNombre", AV7cUsuarioNombre);
            lV8cUsuarioContrasena = StringUtil.PadR( StringUtil.RTrim( AV8cUsuarioContrasena), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioContrasena", AV8cUsuarioContrasena);
            lV9cGrupoCodigo = StringUtil.PadR( StringUtil.RTrim( AV9cGrupoCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupoCodigo", AV9cGrupoCodigo);
            lV11cUsuarioCorreo = StringUtil.PadR( StringUtil.RTrim( AV11cUsuarioCorreo), 80, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCorreo", AV11cUsuarioCorreo);
            lV13cUsuarioTelefono = StringUtil.PadR( StringUtil.RTrim( AV13cUsuarioTelefono), 9, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cUsuarioTelefono", AV13cUsuarioTelefono);
            /* Using cursor H00092 */
            pr_default.execute(0, new Object[] {lV6cUsuarioCodigo, lV7cUsuarioNombre, lV8cUsuarioContrasena, lV9cGrupoCodigo, AV10cUsuarioEstado, lV11cUsuarioCorreo, lV13cUsuarioTelefono});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A1GrupoCodigo = H00092_A1GrupoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
               A7UsuarioEstado = H00092_A7UsuarioEstado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
               A113UsuarioCorreo = H00092_A113UsuarioCorreo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113UsuarioCorreo", A113UsuarioCorreo);
               A365UsuarioTelefono = H00092_A365UsuarioTelefono[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365UsuarioTelefono", A365UsuarioTelefono);
               n365UsuarioTelefono = H00092_n365UsuarioTelefono[0] ;
               A6UsuarioContrasena = H00092_A6UsuarioContrasena[0] ;
               A5UsuarioNombre = H00092_A5UsuarioNombre[0] ;
               A4UsuarioCodigo = H00092_A4UsuarioCodigo[0] ;
               A52UsuarioFoto = H00092_A52UsuarioFoto[0] ;
               n52UsuarioFoto = H00092_n52UsuarioFoto[0] ;
               /* Execute user event: E12092 */
               E12092 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB090( ) ;
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
         lV6cUsuarioCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cUsuarioCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioCodigo", AV6cUsuarioCodigo);
         lV7cUsuarioNombre = StringUtil.PadR( StringUtil.RTrim( AV7cUsuarioNombre), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioNombre", AV7cUsuarioNombre);
         lV8cUsuarioContrasena = StringUtil.PadR( StringUtil.RTrim( AV8cUsuarioContrasena), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioContrasena", AV8cUsuarioContrasena);
         lV9cGrupoCodigo = StringUtil.PadR( StringUtil.RTrim( AV9cGrupoCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupoCodigo", AV9cGrupoCodigo);
         lV11cUsuarioCorreo = StringUtil.PadR( StringUtil.RTrim( AV11cUsuarioCorreo), 80, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCorreo", AV11cUsuarioCorreo);
         lV13cUsuarioTelefono = StringUtil.PadR( StringUtil.RTrim( AV13cUsuarioTelefono), 9, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cUsuarioTelefono", AV13cUsuarioTelefono);
         /* Using cursor H00093 */
         pr_default.execute(1, new Object[] {lV6cUsuarioCodigo, lV7cUsuarioNombre, lV8cUsuarioContrasena, lV9cGrupoCodigo, AV10cUsuarioEstado, lV11cUsuarioCorreo, lV13cUsuarioTelefono});
         GRID1_nRecordCount = H00093_AGRID1_nRecordCount[0] ;
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

      protected void STRUP090( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11092 */
         E11092 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cUsuarioCodigo = cgiGet( edtavCusuariocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioCodigo", AV6cUsuarioCodigo);
            AV7cUsuarioNombre = cgiGet( edtavCusuarionombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioNombre", AV7cUsuarioNombre);
            AV8cUsuarioContrasena = cgiGet( edtavCusuariocontrasena_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioContrasena", AV8cUsuarioContrasena);
            AV9cGrupoCodigo = cgiGet( edtavCgrupocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupoCodigo", AV9cGrupoCodigo);
            cmbavCusuarioestado.Name = cmbavCusuarioestado_Internalname ;
            cmbavCusuarioestado.CurrentValue = cgiGet( cmbavCusuarioestado_Internalname) ;
            AV10cUsuarioEstado = (short)(NumberUtil.Val( cgiGet( cmbavCusuarioestado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioEstado", StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0));
            AV11cUsuarioCorreo = cgiGet( edtavCusuariocorreo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCorreo", AV11cUsuarioCorreo);
            AV13cUsuarioTelefono = cgiGet( edtavCusuariotelefono_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cUsuarioTelefono", AV13cUsuarioTelefono);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV12pUsuarioCodigo = cgiGet( "vPUSUARIOCODIGO") ;
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
         /* Execute user event: E11092 */
         E11092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11092( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Usuarios", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12092( )
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
         /* Execute user event: E13092 */
         E13092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13092( )
      {
         /* Enter Routine */
         AV12pUsuarioCodigo = A4UsuarioCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuarioCodigo", AV12pUsuarioCodigo);
         context.setWebReturnParms(new Object[] {(String)AV12pUsuarioCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_092( bool wbgen )
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
            wb_table2_9_092( true) ;
         }
         else
         {
            wb_table2_9_092( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_092e( bool wbgen )
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
            wb_table3_48_092( true) ;
         }
         else
         {
            wb_table3_48_092( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_092e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_092e( true) ;
         }
         else
         {
            wb_table1_2_092e( false) ;
         }
      }

      protected void wb_table3_48_092( bool wbgen )
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
               context.SendWebValue( "Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Contraseña") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Foto") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A4UsuarioCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A5UsuarioNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtUsuarioNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6UsuarioContrasena));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A52UsuarioFoto));
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
            wb_table4_59_092( true) ;
         }
         else
         {
            wb_table4_59_092( false) ;
         }
         return  ;
      }

      protected void wb_table4_59_092e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_092e( true) ;
         }
         else
         {
            wb_table3_48_092e( false) ;
         }
      }

      protected void wb_table4_59_092( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_59_092e( true) ;
         }
         else
         {
            wb_table4_59_092e( false) ;
         }
      }

      protected void wb_table2_9_092( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioCodigo", AV6cUsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusuariocodigo_Internalname, StringUtil.RTrim( AV6cUsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cUsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCusuariocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuarionombre_Internalname, "Usuario", "", "", lblTextblockusuarionombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioNombre", AV7cUsuarioNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusuarionombre_Internalname, StringUtil.RTrim( AV7cUsuarioNombre), StringUtil.RTrim( context.localUtil.Format( AV7cUsuarioNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCusuarionombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocontrasena_Internalname, "Contraseña", "", "", lblTextblockusuariocontrasena_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioContrasena", AV8cUsuarioContrasena);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusuariocontrasena_Internalname, StringUtil.RTrim( AV8cUsuarioContrasena), StringUtil.RTrim( context.localUtil.Format( AV8cUsuarioContrasena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", "", "", "", edtavCusuariocontrasena_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, -1, 0, 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupocodigo_Internalname, "Grupo", "", "", lblTextblockgrupocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupoCodigo", AV9cGrupoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgrupocodigo_Internalname, StringUtil.RTrim( AV9cGrupoCodigo), StringUtil.RTrim( context.localUtil.Format( AV9cGrupoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavCgrupocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuarioestado_Internalname, "Estado", "", "", lblTextblockusuarioestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioEstado", StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCusuarioestado, cmbavCusuarioestado_Internalname, StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0), 1, cmbavCusuarioestado_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", true, "HLP_Gx0020.htm");
            cmbavCusuarioestado.CurrentValue = StringUtil.Str( (decimal)(AV10cUsuarioEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusuarioestado_Internalname, "Values", (String)(cmbavCusuarioestado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocorreo_Internalname, "Correo", "", "", lblTextblockusuariocorreo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCorreo", AV11cUsuarioCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusuariocorreo_Internalname, StringUtil.RTrim( AV11cUsuarioCorreo), StringUtil.RTrim( context.localUtil.Format( AV11cUsuarioCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", "", "", "", edtavCusuariocorreo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariotelefono_Internalname, "Teléfono", "", "", lblTextblockusuariotelefono_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cUsuarioTelefono", AV13cUsuarioTelefono);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusuariotelefono_Internalname, StringUtil.RTrim( AV13cUsuarioTelefono), StringUtil.RTrim( context.localUtil.Format( AV13cUsuarioTelefono, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", "", "", "", "", edtavCusuariotelefono_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_092e( true) ;
         }
         else
         {
            wb_table2_9_092e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pUsuarioCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuarioCodigo", AV12pUsuarioCodigo);
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
         PA092( ) ;
         WS092( ) ;
         WE092( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1582367");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx0020.js", "?1582367");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB090( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A4UsuarioCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioCodigo_Internalname,StringUtil.RTrim( A4UsuarioCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtUsuarioNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A4UsuarioCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioNombre_Internalname,StringUtil.RTrim( A5UsuarioNombre),(String)"",(String)"",(String)"",(String)edtUsuarioNombre_Link,(String)"",(String)"Seleccionar",(String)edtUsuarioNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioContrasena_Internalname,StringUtil.RTrim( A6UsuarioContrasena),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioContrasena_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)-1,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Image" ;
            StyleString = "" ;
            edtUsuarioFoto_Filetype = "JPG" ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A52UsuarioFoto)) )
            {
               gxblobfileaux.Source = A52UsuarioFoto ;
               gxblobfileaux.SetExtension(StringUtil.Trim( edtUsuarioFoto_Filetype));
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A52UsuarioFoto = gxblobfileaux.GetAbsoluteName() ;
                  n52UsuarioFoto = false ;
               }
            }
            Grid1Row.AddColumnProperties("blob", 2, isAjaxCallMode( ), new Object[] {(String)edtUsuarioFoto_Internalname,StringUtil.RTrim( A52UsuarioFoto),context.PathToRelativeUrl( A52UsuarioFoto),(String.IsNullOrEmpty(StringUtil.RTrim( edtUsuarioFoto_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtUsuarioFoto_Filetype)) ? A52UsuarioFoto : edtUsuarioFoto_Filetype)) : edtUsuarioFoto_Contenttype),(bool)false,(String)"",(String)edtUsuarioFoto_Parameters,(short)0,(short)0,(short)-1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)60,(String)"px",(short)0,(short)0,(short)0,(String)edtUsuarioFoto_Jsonclick,(String)"",(String)StyleString,(String)ClassString,(String)""+"",(String)""});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
            edtUsuarioNombre_Internalname = "USUARIONOMBRE_"+sGXsfl_51_idx ;
            edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA_"+sGXsfl_51_idx ;
            edtUsuarioFoto_Internalname = "USUARIOFOTO_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtavCusuariocodigo_Internalname = "vCUSUARIOCODIGO" ;
         lblTextblockusuarionombre_Internalname = "TEXTBLOCKUSUARIONOMBRE" ;
         edtavCusuarionombre_Internalname = "vCUSUARIONOMBRE" ;
         lblTextblockusuariocontrasena_Internalname = "TEXTBLOCKUSUARIOCONTRASENA" ;
         edtavCusuariocontrasena_Internalname = "vCUSUARIOCONTRASENA" ;
         lblTextblockgrupocodigo_Internalname = "TEXTBLOCKGRUPOCODIGO" ;
         edtavCgrupocodigo_Internalname = "vCGRUPOCODIGO" ;
         lblTextblockusuarioestado_Internalname = "TEXTBLOCKUSUARIOESTADO" ;
         cmbavCusuarioestado_Internalname = "vCUSUARIOESTADO" ;
         lblTextblockusuariocorreo_Internalname = "TEXTBLOCKUSUARIOCORREO" ;
         edtavCusuariocorreo_Internalname = "vCUSUARIOCORREO" ;
         lblTextblockusuariotelefono_Internalname = "TEXTBLOCKUSUARIOTELEFONO" ;
         edtavCusuariotelefono_Internalname = "vCUSUARIOTELEFONO" ;
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
         edtUsuarioFoto_Jsonclick = "" ;
         edtUsuarioFoto_Parameters = "" ;
         edtUsuarioFoto_Contenttype = "" ;
         edtUsuarioFoto_Filetype = "" ;
         edtUsuarioContrasena_Jsonclick = "" ;
         edtUsuarioNombre_Jsonclick = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtavCusuariotelefono_Jsonclick = "" ;
         edtavCusuariocorreo_Jsonclick = "" ;
         cmbavCusuarioestado_Jsonclick = "" ;
         edtavCgrupocodigo_Jsonclick = "" ;
         edtavCusuariocontrasena_Jsonclick = "" ;
         edtavCusuarionombre_Jsonclick = "" ;
         edtavCusuariocodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtUsuarioNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Usuarios" ;
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
         AV6cUsuarioCodigo = "" ;
         AV7cUsuarioNombre = "" ;
         AV8cUsuarioContrasena = "" ;
         AV9cGrupoCodigo = "" ;
         AV11cUsuarioCorreo = "" ;
         AV13cUsuarioTelefono = "" ;
         AV12pUsuarioCodigo = "" ;
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
         edtUsuarioCodigo_Internalname = "" ;
         edtUsuarioNombre_Internalname = "" ;
         edtUsuarioContrasena_Internalname = "" ;
         edtUsuarioFoto_Internalname = "" ;
         AV5LinkSelection = "" ;
         A4UsuarioCodigo = "" ;
         A5UsuarioNombre = "" ;
         A6UsuarioContrasena = "" ;
         A52UsuarioFoto = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cUsuarioCodigo = "" ;
         lV7cUsuarioNombre = "" ;
         lV8cUsuarioContrasena = "" ;
         lV9cGrupoCodigo = "" ;
         lV11cUsuarioCorreo = "" ;
         lV13cUsuarioTelefono = "" ;
         H00092_A1GrupoCodigo = new String[] {""} ;
         H00092_A7UsuarioEstado = new short[1] ;
         H00092_A113UsuarioCorreo = new String[] {""} ;
         H00092_A365UsuarioTelefono = new String[] {""} ;
         H00092_n365UsuarioTelefono = new bool[] {false} ;
         H00092_A6UsuarioContrasena = new String[] {""} ;
         H00092_A5UsuarioNombre = new String[] {""} ;
         H00092_A4UsuarioCodigo = new String[] {""} ;
         H00092_A52UsuarioFoto = new String[] {""} ;
         H00092_n52UsuarioFoto = new bool[] {false} ;
         A1GrupoCodigo = "" ;
         A113UsuarioCorreo = "" ;
         A365UsuarioTelefono = "" ;
         H00093_AGRID1_nRecordCount = new int[1] ;
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
         lblTextblockusuariocodigo_Jsonclick = "" ;
         lblTextblockusuarionombre_Jsonclick = "" ;
         lblTextblockusuariocontrasena_Jsonclick = "" ;
         lblTextblockgrupocodigo_Jsonclick = "" ;
         lblTextblockusuarioestado_Jsonclick = "" ;
         lblTextblockusuariocorreo_Jsonclick = "" ;
         lblTextblockusuariotelefono_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char5 = "" ;
         ROClassString = "" ;
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0020__default(),
            new Object[][] {
                new Object[] {
               H00092_A1GrupoCodigo, H00092_A7UsuarioEstado, H00092_A113UsuarioCorreo, H00092_A365UsuarioTelefono, H00092_n365UsuarioTelefono, H00092_A6UsuarioContrasena, H00092_A5UsuarioNombre, H00092_A4UsuarioCodigo, H00092_A52UsuarioFoto, H00092_n52UsuarioFoto
               }
               , new Object[] {
               H00093_AGRID1_nRecordCount
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
      private short AV10cUsuarioEstado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A7UsuarioEstado ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
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
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioNombre_Internalname ;
      private String edtUsuarioContrasena_Internalname ;
      private String edtUsuarioFoto_Internalname ;
      private String edtavCusuariocodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCusuarionombre_Internalname ;
      private String edtavCusuariocontrasena_Internalname ;
      private String edtavCgrupocodigo_Internalname ;
      private String cmbavCusuarioestado_Internalname ;
      private String edtavCusuariocorreo_Internalname ;
      private String edtavCusuariotelefono_Internalname ;
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
      private String edtUsuarioNombre_Link ;
      private String GXt_char4 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtavCusuariocodigo_Jsonclick ;
      private String lblTextblockusuarionombre_Internalname ;
      private String lblTextblockusuarionombre_Jsonclick ;
      private String edtavCusuarionombre_Jsonclick ;
      private String lblTextblockusuariocontrasena_Internalname ;
      private String lblTextblockusuariocontrasena_Jsonclick ;
      private String edtavCusuariocontrasena_Jsonclick ;
      private String lblTextblockgrupocodigo_Internalname ;
      private String lblTextblockgrupocodigo_Jsonclick ;
      private String edtavCgrupocodigo_Jsonclick ;
      private String lblTextblockusuarioestado_Internalname ;
      private String lblTextblockusuarioestado_Jsonclick ;
      private String cmbavCusuarioestado_Jsonclick ;
      private String lblTextblockusuariocorreo_Internalname ;
      private String lblTextblockusuariocorreo_Jsonclick ;
      private String edtavCusuariocorreo_Jsonclick ;
      private String lblTextblockusuariotelefono_Internalname ;
      private String lblTextblockusuariotelefono_Jsonclick ;
      private String edtavCusuariotelefono_Jsonclick ;
      private String GXt_char5 ;
      private String ROClassString ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String edtUsuarioNombre_Jsonclick ;
      private String edtUsuarioContrasena_Jsonclick ;
      private String edtUsuarioFoto_Filetype ;
      private String edtUsuarioFoto_Contenttype ;
      private String edtUsuarioFoto_Parameters ;
      private String edtUsuarioFoto_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n52UsuarioFoto ;
      private bool n365UsuarioTelefono ;
      private bool returnInSub ;
      private String AV6cUsuarioCodigo ;
      private String AV7cUsuarioNombre ;
      private String AV8cUsuarioContrasena ;
      private String AV9cGrupoCodigo ;
      private String AV11cUsuarioCorreo ;
      private String AV13cUsuarioTelefono ;
      private String AV12pUsuarioCodigo ;
      private String A4UsuarioCodigo ;
      private String A5UsuarioNombre ;
      private String A6UsuarioContrasena ;
      private String lV6cUsuarioCodigo ;
      private String lV7cUsuarioNombre ;
      private String lV8cUsuarioContrasena ;
      private String lV9cGrupoCodigo ;
      private String lV11cUsuarioCorreo ;
      private String lV13cUsuarioTelefono ;
      private String A1GrupoCodigo ;
      private String A113UsuarioCorreo ;
      private String A365UsuarioTelefono ;
      private String AV5LinkSelection ;
      private String A52UsuarioFoto ;
      private GxFile gxblobfileaux ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCusuarioestado ;
      private IDataStoreProvider pr_default ;
      private String[] H00092_A1GrupoCodigo ;
      private short[] H00092_A7UsuarioEstado ;
      private String[] H00092_A113UsuarioCorreo ;
      private String[] H00092_A365UsuarioTelefono ;
      private bool[] H00092_n365UsuarioTelefono ;
      private String[] H00092_A6UsuarioContrasena ;
      private String[] H00092_A5UsuarioNombre ;
      private String[] H00092_A4UsuarioCodigo ;
      private String[] H00092_A52UsuarioFoto ;
      private bool[] H00092_n52UsuarioFoto ;
      private int[] H00093_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pUsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class gx0020__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00092 ;
          prmH00092 = new Object[] {
          new Object[] {"@lV6cUsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cUsuarioNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV8cUsuarioContrasena",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV9cGrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10cUsuarioEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV11cUsuarioCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@lV13cUsuarioTelefono",SqlDbType.VarChar,9,0}
          } ;
          Object[] prmH00093 ;
          prmH00093 = new Object[] {
          new Object[] {"@lV6cUsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cUsuarioNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV8cUsuarioContrasena",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV9cGrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10cUsuarioEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV11cUsuarioCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@lV13cUsuarioTelefono",SqlDbType.VarChar,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00092", "SELECT [GrupoCodigo], [UsuarioEstado], [UsuarioCorreo], [UsuarioTelefono], [UsuarioContrasena], [UsuarioNombre], [UsuarioCodigo], [UsuarioFoto] FROM [Usuario] WITH (NOLOCK) WHERE ([UsuarioCodigo] like @lV6cUsuarioCodigo) AND ([UsuarioNombre] like @lV7cUsuarioNombre) AND ([UsuarioContrasena] like @lV8cUsuarioContrasena) AND ([GrupoCodigo] like @lV9cGrupoCodigo) AND ([UsuarioEstado] >= @AV10cUsuarioEstado) AND ([UsuarioCorreo] like @lV11cUsuarioCorreo) AND ([UsuarioTelefono] like @lV13cUsuarioTelefono) ORDER BY [UsuarioCodigo]  OPTION (FAST 1)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00092,1,0,false,false )
             ,new CursorDef("H00093", "SELECT COUNT(*) FROM [Usuario] WITH (NOLOCK) WHERE ([UsuarioCodigo] like @lV6cUsuarioCodigo) AND ([UsuarioNombre] like @lV7cUsuarioNombre) AND ([UsuarioContrasena] like @lV8cUsuarioContrasena) AND ([GrupoCodigo] like @lV9cGrupoCodigo) AND ([UsuarioEstado] >= @AV10cUsuarioEstado) AND ([UsuarioCorreo] like @lV11cUsuarioCorreo) AND ([UsuarioTelefono] like @lV13cUsuarioTelefono) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00093,1,0,false,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[8])[0] = rslt.getBLOBFile(8, "JPG", "") ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
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
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
