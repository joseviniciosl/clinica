/*
               File: pRegistraSesion
        Description: Registra sesión del usuario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:33.40
       Program type: Callable routine
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
   public class pregistrasesion : GXProcedure
   {
      public pregistrasesion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrasesion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( SdtParametros aP0_Parametros )
      {
         this.AV8Parametros = aP0_Parametros;
         initialize();
         executePrivate();
      }

      public void executeSubmit( SdtParametros aP0_Parametros )
      {
         pregistrasesion objpregistrasesion;
         objpregistrasesion = new pregistrasesion();
         objpregistrasesion.AV8Parametros = aP0_Parametros;
         objpregistrasesion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrasesion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrasesion)stateInfo).executePrivate();
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
         AV9WebSession.Set("Parametros", AV8Parametros.ToXml(false, "Parametros", "Clinica"));
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
         AV9WebSession = new GxWebSession( context);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private GxWebSession AV9WebSession ;
      private SdtParametros AV8Parametros ;
   }

}
