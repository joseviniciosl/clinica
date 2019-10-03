/*
               File: LoadEventsSampleProc
        Description: Load Events Sample Proc
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:39.81
       Program type: Main program
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
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
   public class aloadeventssampleproc : GXProcedure
   {
      public aloadeventssampleproc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public aloadeventssampleproc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out SdtSchedulerEvents aP0_events )
      {
         this.AV9events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP0_events=this.AV9events;
      }

      public SdtSchedulerEvents executeUdp( )
      {
         this.AV9events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP0_events=this.AV9events;
         return AV9events ;
      }

      public void executeSubmit( out SdtSchedulerEvents aP0_events )
      {
         aloadeventssampleproc objaloadeventssampleproc;
         objaloadeventssampleproc = new aloadeventssampleproc();
         objaloadeventssampleproc.AV9events = new SdtSchedulerEvents(context) ;
         objaloadeventssampleproc.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objaloadeventssampleproc);
         aP0_events=this.AV9events;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((aloadeventssampleproc)stateInfo).executePrivate();
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
         GXt_SdtParametros1 = AV12Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros1) ;
         AV12Parametros = GXt_SdtParametros1 ;
         AV13ClinicaCodigo = AV12Parametros.gxTpr_Pclinicacodigo ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV12Parametros = new SdtParametros(context);
         GXt_SdtParametros1 = new SdtParametros(context);
         AV13ClinicaCodigo = "" ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV13ClinicaCodigo ;
      private SdtSchedulerEvents aP0_events ;
      private SdtSchedulerEvents AV9events ;
      private SdtParametros AV12Parametros ;
      private SdtParametros GXt_SdtParametros1 ;
   }

}
