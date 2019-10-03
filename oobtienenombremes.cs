/*
               File: oObtieneNombreMes
        Description: Obtiene el nombre del mes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:0.51
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
   public class oobtienenombremes : GXProcedure
   {
      public oobtienenombremes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienenombremes( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( short aP0_Mes ,
                           out String aP1_NombreMes )
      {
         this.AV8Mes = aP0_Mes;
         this.AV9NombreMes = "" ;
         initialize();
         executePrivate();
         aP1_NombreMes=this.AV9NombreMes;
      }

      public String executeUdp( short aP0_Mes )
      {
         this.AV8Mes = aP0_Mes;
         this.AV9NombreMes = "" ;
         initialize();
         executePrivate();
         aP1_NombreMes=this.AV9NombreMes;
         return AV9NombreMes ;
      }

      public void executeSubmit( short aP0_Mes ,
                                 out String aP1_NombreMes )
      {
         oobtienenombremes objoobtienenombremes;
         objoobtienenombremes = new oobtienenombremes();
         objoobtienenombremes.AV8Mes = aP0_Mes;
         objoobtienenombremes.AV9NombreMes = "" ;
         objoobtienenombremes.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienenombremes);
         aP1_NombreMes=this.AV9NombreMes;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienenombremes)stateInfo).executePrivate();
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
         if ( AV8Mes == 1 )
         {
            AV9NombreMes = "Enero" ;
         }
         else if ( AV8Mes == 2 )
         {
            AV9NombreMes = "Febrero" ;
         }
         else if ( AV8Mes == 3 )
         {
            AV9NombreMes = "Marzo" ;
         }
         else if ( AV8Mes == 4 )
         {
            AV9NombreMes = "Abril" ;
         }
         else if ( AV8Mes == 5 )
         {
            AV9NombreMes = "Mayo" ;
         }
         else if ( AV8Mes == 6 )
         {
            AV9NombreMes = "Junio" ;
         }
         else if ( AV8Mes == 7 )
         {
            AV9NombreMes = "Julio" ;
         }
         else if ( AV8Mes == 8 )
         {
            AV9NombreMes = "Agosto" ;
         }
         else if ( AV8Mes == 9 )
         {
            AV9NombreMes = "Septiembre" ;
         }
         else if ( AV8Mes == 10 )
         {
            AV9NombreMes = "Octubre" ;
         }
         else if ( AV8Mes == 11 )
         {
            AV9NombreMes = "Noviembre" ;
         }
         else if ( AV8Mes == 12 )
         {
            AV9NombreMes = "Diciembre" ;
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
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8Mes ;
      private String AV9NombreMes ;
      private String aP1_NombreMes ;
   }

}
