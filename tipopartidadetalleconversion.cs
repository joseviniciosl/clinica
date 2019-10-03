/*
               File: TipoPartidaDetalleConversion
        Description: Conversion for table TipoPartidaDetalle
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.83
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tipopartidadetalleconversion : GXProcedure
   {
      public tipopartidadetalleconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipopartidadetalleconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         tipopartidadetalleconversion objtipopartidadetalleconversion;
         objtipopartidadetalleconversion = new tipopartidadetalleconversion();
         objtipopartidadetalleconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipopartidadetalleconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipopartidadetalleconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOPARTID2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A205TipoParSiguiente = TIPOPARTID2_A205TipoParSiguiente[0] ;
            A204TipoParAnio = TIPOPARTID2_A204TipoParAnio[0] ;
            A199TipoParCodigo = TIPOPARTID2_A199TipoParCodigo[0] ;
            A41ClinicaCodigo = TIPOPARTID2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOPARTID2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0052

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoParCodigo = A199TipoParCodigo ;
            AV4TipoParAnio = A204TipoParAnio ;
            AV5TipoParSiguiente = A205TipoParSiguiente ;
            /* Using cursor TIPOPARTID3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoParCodigo, AV4TipoParAnio, AV5TipoParSiguiente});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         scmdbuf = "" ;
         TIPOPARTID2_A205TipoParSiguiente = new int[1] ;
         TIPOPARTID2_A204TipoParAnio = new short[1] ;
         TIPOPARTID2_A199TipoParCodigo = new String[] {""} ;
         TIPOPARTID2_A41ClinicaCodigo = new String[] {""} ;
         TIPOPARTID2_A40000GXC1 = new int[1] ;
         A199TipoParCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoParCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipopartidadetalleconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOPARTID2_A205TipoParSiguiente, TIPOPARTID2_A204TipoParAnio, TIPOPARTID2_A199TipoParCodigo, TIPOPARTID2_A41ClinicaCodigo, TIPOPARTID2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A204TipoParAnio ;
      private short AV4TipoParAnio ;
      private int A205TipoParSiguiente ;
      private int A40000GXC1 ;
      private int GIGXA0052 ;
      private int AV2ClinicaCodigo ;
      private int AV5TipoParSiguiente ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A199TipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoParCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] TIPOPARTID2_A205TipoParSiguiente ;
      private short[] TIPOPARTID2_A204TipoParAnio ;
      private String[] TIPOPARTID2_A199TipoParCodigo ;
      private String[] TIPOPARTID2_A41ClinicaCodigo ;
      private int[] TIPOPARTID2_A40000GXC1 ;
   }

   public class tipopartidadetalleconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmTIPOPARTID2 ;
          prmTIPOPARTID2 = new Object[] {
          } ;
          Object[] prmTIPOPARTID3 ;
          prmTIPOPARTID3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoParAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5TipoParSiguiente",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOPARTID2", "SELECT [TipoParSiguiente], [TipoParAnio], [TipoParCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoPartidaDetalle] ORDER BY [ClinicaCodigo], [TipoParCodigo], [TipoParAnio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOPARTID2,100,0,true,false )
             ,new CursorDef("TIPOPARTID3", "INSERT INTO [GXA0052] ([ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente]) VALUES (@AV2ClinicaCodigo, @AV3TipoParCodigo, @AV4TipoParAnio, @AV5TipoParSiguiente)", GxErrorMask.GX_NOMASK,prmTIPOPARTID3)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
