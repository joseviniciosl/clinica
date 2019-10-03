/*
               File: rRecetaMedica
        Description: Stub for rRecetaMedica
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:59.88
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Web.Services.Protocols;
using System.Web.Services;
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class rrecetamedica : GXProcedure
   {
      public rrecetamedica( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rrecetamedica( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId )
      {
         this.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV3ConsultaId = aP1_ConsultaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_ConsultaId=this.AV3ConsultaId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo )
      {
         this.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV3ConsultaId = aP1_ConsultaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_ConsultaId=this.AV3ConsultaId;
         return AV3ConsultaId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId )
      {
         rrecetamedica objrrecetamedica;
         objrrecetamedica = new rrecetamedica();
         objrrecetamedica.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         objrrecetamedica.AV3ConsultaId = aP1_ConsultaId;
         objrrecetamedica.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objrrecetamedica);
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_ConsultaId=this.AV3ConsultaId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((rrecetamedica)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         args = new Object[] {(String)AV2ClinicaCodigo,(int)AV3ConsultaId} ;
         ClassLoader.Execute("arrecetamedica","GeneXus.Programs.arrecetamedica", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 2 ) )
         {
            AV2ClinicaCodigo = (String)(args[0]) ;
            AV3ConsultaId = (int)(args[1]) ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
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
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV3ConsultaId ;
      private String AV2ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private Object[] args ;
   }

}
