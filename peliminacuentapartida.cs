/*
               File: pEliminaCuentaPartida
        Description: Elimina Cuenta Contable de Partida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:57.22
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class peliminacuentapartida : GXProcedure
   {
      public peliminacuentapartida( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public peliminacuentapartida( IGxContext context )
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
                           ref int aP2_PartidaId ,
                           ref short aP3_PartidaLinea )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV9PartidaLinea = aP3_PartidaLinea;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaLinea=this.AV9PartidaLinea;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_TipoParCodigo ,
                               ref int aP2_PartidaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV9PartidaLinea = aP3_PartidaLinea;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaLinea=this.AV9PartidaLinea;
         return AV9PartidaLinea ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref short aP3_PartidaLinea )
      {
         peliminacuentapartida objpeliminacuentapartida;
         objpeliminacuentapartida = new peliminacuentapartida();
         objpeliminacuentapartida.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpeliminacuentapartida.A199TipoParCodigo = aP1_TipoParCodigo;
         objpeliminacuentapartida.A207PartidaId = aP2_PartidaId;
         objpeliminacuentapartida.AV9PartidaLinea = aP3_PartidaLinea;
         objpeliminacuentapartida.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpeliminacuentapartida);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaLinea=this.AV9PartidaLinea;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((peliminacuentapartida)stateInfo).executePrivate();
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
         /* Optimized DELETE. */
         /* Using cursor P00192 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, AV9PartidaLinea});
         pr_default.close(0);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pEliminaCuentaPartida");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.peliminacuentapartida__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9PartidaLinea ;
      private int A207PartidaId ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private short aP3_PartidaLinea ;
      private IDataStoreProvider pr_default ;
   }

   public class peliminacuentapartida__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00192 ;
          prmP00192 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9PartidaLinea",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00192", "DELETE FROM [PartidaDet]  WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId and [PartidaLinea] = @AV9PartidaLinea", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00192)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
