/*
               File: rBalanceGeneral
        Description: Stub for rBalanceGeneral
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:59.83
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
   public class rbalancegeneral : GXProcedure
   {
      public rbalancegeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rbalancegeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref short aP1_Anio ,
                           ref short aP2_Mes ,
                           ref String aP3_Tipo ,
                           ref String aP4_UsuarioCodigo )
      {
         this.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV3Anio = aP1_Anio;
         this.AV4Mes = aP2_Mes;
         this.AV5Tipo = aP3_Tipo;
         this.AV6UsuarioCodigo = aP4_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_Anio=this.AV3Anio;
         aP2_Mes=this.AV4Mes;
         aP3_Tipo=this.AV5Tipo;
         aP4_UsuarioCodigo=this.AV6UsuarioCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref short aP1_Anio ,
                                ref short aP2_Mes ,
                                ref String aP3_Tipo )
      {
         this.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV3Anio = aP1_Anio;
         this.AV4Mes = aP2_Mes;
         this.AV5Tipo = aP3_Tipo;
         this.AV6UsuarioCodigo = aP4_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_Anio=this.AV3Anio;
         aP2_Mes=this.AV4Mes;
         aP3_Tipo=this.AV5Tipo;
         aP4_UsuarioCodigo=this.AV6UsuarioCodigo;
         return AV6UsuarioCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref short aP1_Anio ,
                                 ref short aP2_Mes ,
                                 ref String aP3_Tipo ,
                                 ref String aP4_UsuarioCodigo )
      {
         rbalancegeneral objrbalancegeneral;
         objrbalancegeneral = new rbalancegeneral();
         objrbalancegeneral.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         objrbalancegeneral.AV3Anio = aP1_Anio;
         objrbalancegeneral.AV4Mes = aP2_Mes;
         objrbalancegeneral.AV5Tipo = aP3_Tipo;
         objrbalancegeneral.AV6UsuarioCodigo = aP4_UsuarioCodigo;
         objrbalancegeneral.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objrbalancegeneral);
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_Anio=this.AV3Anio;
         aP2_Mes=this.AV4Mes;
         aP3_Tipo=this.AV5Tipo;
         aP4_UsuarioCodigo=this.AV6UsuarioCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((rbalancegeneral)stateInfo).executePrivate();
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
         args = new Object[] {(String)AV2ClinicaCodigo,(short)AV3Anio,(short)AV4Mes,(String)AV5Tipo,(String)AV6UsuarioCodigo} ;
         ClassLoader.Execute("arbalancegeneral","GeneXus.Programs.arbalancegeneral", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 5 ) )
         {
            AV2ClinicaCodigo = (String)(args[0]) ;
            AV3Anio = (short)(args[1]) ;
            AV4Mes = (short)(args[2]) ;
            AV5Tipo = (String)(args[3]) ;
            AV6UsuarioCodigo = (String)(args[4]) ;
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

      private short AV3Anio ;
      private short AV4Mes ;
      private String AV2ClinicaCodigo ;
      private String AV5Tipo ;
      private String AV6UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private short aP1_Anio ;
      private short aP2_Mes ;
      private String aP3_Tipo ;
      private String aP4_UsuarioCodigo ;
      private Object[] args ;
   }

}
