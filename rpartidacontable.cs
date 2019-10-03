/*
               File: rPartidaContable
        Description: Stub for rPartidaContable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:59.86
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
   public class rpartidacontable : GXProcedure
   {
      public rpartidacontable( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rpartidacontable( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_TipoParCodigo ,
                           ref int aP2_PartidaId )
      {
         this.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV3TipoParCodigo = aP1_TipoParCodigo;
         this.AV4PartidaId = aP2_PartidaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_TipoParCodigo=this.AV3TipoParCodigo;
         aP2_PartidaId=this.AV4PartidaId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo ,
                             ref String aP1_TipoParCodigo )
      {
         this.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV3TipoParCodigo = aP1_TipoParCodigo;
         this.AV4PartidaId = aP2_PartidaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_TipoParCodigo=this.AV3TipoParCodigo;
         aP2_PartidaId=this.AV4PartidaId;
         return AV4PartidaId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId )
      {
         rpartidacontable objrpartidacontable;
         objrpartidacontable = new rpartidacontable();
         objrpartidacontable.AV2ClinicaCodigo = aP0_ClinicaCodigo;
         objrpartidacontable.AV3TipoParCodigo = aP1_TipoParCodigo;
         objrpartidacontable.AV4PartidaId = aP2_PartidaId;
         objrpartidacontable.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objrpartidacontable);
         aP0_ClinicaCodigo=this.AV2ClinicaCodigo;
         aP1_TipoParCodigo=this.AV3TipoParCodigo;
         aP2_PartidaId=this.AV4PartidaId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((rpartidacontable)stateInfo).executePrivate();
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
         args = new Object[] {(String)AV2ClinicaCodigo,(String)AV3TipoParCodigo,(int)AV4PartidaId} ;
         ClassLoader.Execute("arpartidacontable","GeneXus.Programs.arpartidacontable", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 3 ) )
         {
            AV2ClinicaCodigo = (String)(args[0]) ;
            AV3TipoParCodigo = (String)(args[1]) ;
            AV4PartidaId = (int)(args[2]) ;
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

      private int AV4PartidaId ;
      private String AV2ClinicaCodigo ;
      private String AV3TipoParCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private Object[] args ;
   }

}
