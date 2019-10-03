/*
               File: pObtieneSesion
        Description: Obtiene sesión del usuario logueado
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:33.24
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
   public class pobtienesesion : GXProcedure
   {
      public pobtienesesion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pobtienesesion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out SdtParametros aP0_Parametros )
      {
         this.AV8Parametros = new SdtParametros(context) ;
         initialize();
         executePrivate();
         aP0_Parametros=this.AV8Parametros;
      }

      public SdtParametros executeUdp( )
      {
         this.AV8Parametros = new SdtParametros(context) ;
         initialize();
         executePrivate();
         aP0_Parametros=this.AV8Parametros;
         return AV8Parametros ;
      }

      public void executeSubmit( out SdtParametros aP0_Parametros )
      {
         pobtienesesion objpobtienesesion;
         objpobtienesesion = new pobtienesesion();
         objpobtienesesion.AV8Parametros = new SdtParametros(context) ;
         objpobtienesesion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpobtienesesion);
         aP0_Parametros=this.AV8Parametros;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pobtienesesion)stateInfo).executePrivate();
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
         AV8Parametros.FromXml(AV9WebSession.Get("Parametros"), "");
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
      private SdtParametros aP0_Parametros ;
      private SdtParametros AV8Parametros ;
   }

}
