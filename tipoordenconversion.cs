/*
               File: TipoOrdenConversion
        Description: Conversion for table TipoOrden
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.57
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
   public class tipoordenconversion : GXProcedure
   {
      public tipoordenconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipoordenconversion( IGxContext context )
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
         tipoordenconversion objtipoordenconversion;
         objtipoordenconversion = new tipoordenconversion();
         objtipoordenconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipoordenconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipoordenconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOORDENC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A152TipoOrdEstado = TIPOORDENC2_A152TipoOrdEstado[0] ;
            A151TipoOrdDescripcion = TIPOORDENC2_A151TipoOrdDescripcion[0] ;
            A150TipoOrdCodigo = TIPOORDENC2_A150TipoOrdCodigo[0] ;
            A41ClinicaCodigo = TIPOORDENC2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOORDENC2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0042

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoOrdCodigo = A150TipoOrdCodigo ;
            AV4TipoOrdDescripcion = A151TipoOrdDescripcion ;
            AV5TipoOrdEstado = A152TipoOrdEstado ;
            /* Using cursor TIPOORDENC3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoOrdCodigo, AV4TipoOrdDescripcion, AV5TipoOrdEstado});
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
         TIPOORDENC2_A152TipoOrdEstado = new short[1] ;
         TIPOORDENC2_A151TipoOrdDescripcion = new String[] {""} ;
         TIPOORDENC2_A150TipoOrdCodigo = new String[] {""} ;
         TIPOORDENC2_A41ClinicaCodigo = new String[] {""} ;
         TIPOORDENC2_A40000GXC1 = new int[1] ;
         A151TipoOrdDescripcion = "" ;
         A150TipoOrdCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoOrdCodigo = "" ;
         AV4TipoOrdDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipoordenconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOORDENC2_A152TipoOrdEstado, TIPOORDENC2_A151TipoOrdDescripcion, TIPOORDENC2_A150TipoOrdCodigo, TIPOORDENC2_A41ClinicaCodigo, TIPOORDENC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A152TipoOrdEstado ;
      private short AV5TipoOrdEstado ;
      private int A40000GXC1 ;
      private int GIGXA0042 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A151TipoOrdDescripcion ;
      private String A150TipoOrdCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoOrdCodigo ;
      private String AV4TipoOrdDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TIPOORDENC2_A152TipoOrdEstado ;
      private String[] TIPOORDENC2_A151TipoOrdDescripcion ;
      private String[] TIPOORDENC2_A150TipoOrdCodigo ;
      private String[] TIPOORDENC2_A41ClinicaCodigo ;
      private int[] TIPOORDENC2_A40000GXC1 ;
   }

   public class tipoordenconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOORDENC2 ;
          prmTIPOORDENC2 = new Object[] {
          } ;
          Object[] prmTIPOORDENC3 ;
          prmTIPOORDENC3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoOrdCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoOrdDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5TipoOrdEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOORDENC2", "SELECT [TipoOrdEstado], [TipoOrdDescripcion], [TipoOrdCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoOrden] ORDER BY [ClinicaCodigo], [TipoOrdCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOORDENC2,100,0,true,false )
             ,new CursorDef("TIPOORDENC3", "INSERT INTO [GXA0042] ([ClinicaCodigo], [TipoOrdCodigo], [TipoOrdDescripcion], [TipoOrdEstado]) VALUES (@AV2ClinicaCodigo, @AV3TipoOrdCodigo, @AV4TipoOrdDescripcion, @AV5TipoOrdEstado)", GxErrorMask.GX_NOMASK,prmTIPOORDENC3)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
