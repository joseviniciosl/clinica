/*
               File: oObtieneCorrelativoPartida
        Description: Obtiene Correlativo de la Partida Contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:53.85
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
   public class oobtienecorrelativopartida : GXProcedure
   {
      public oobtienecorrelativopartida( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecorrelativopartida( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           String aP1_TipoParCodigo ,
                           out int aP2_TipoParSiguiente )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.AV9TipoParSiguiente = 0 ;
         initialize();
         executePrivate();
         aP2_TipoParSiguiente=this.AV9TipoParSiguiente;
      }

      public int executeUdp( String aP0_ClinicaCodigo ,
                             String aP1_TipoParCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.AV9TipoParSiguiente = 0 ;
         initialize();
         executePrivate();
         aP2_TipoParSiguiente=this.AV9TipoParSiguiente;
         return AV9TipoParSiguiente ;
      }

      public void executeSubmit( String aP0_ClinicaCodigo ,
                                 String aP1_TipoParCodigo ,
                                 out int aP2_TipoParSiguiente )
      {
         oobtienecorrelativopartida objoobtienecorrelativopartida;
         objoobtienecorrelativopartida = new oobtienecorrelativopartida();
         objoobtienecorrelativopartida.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecorrelativopartida.A199TipoParCodigo = aP1_TipoParCodigo;
         objoobtienecorrelativopartida.AV9TipoParSiguiente = 0 ;
         objoobtienecorrelativopartida.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecorrelativopartida);
         aP2_TipoParSiguiente=this.AV9TipoParSiguiente;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecorrelativopartida)stateInfo).executePrivate();
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
         AV12GXLvl2 = 0 ;
         /* Using cursor P00122 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, Gx_date});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A204TipoParAnio = P00122_A204TipoParAnio[0] ;
            A205TipoParSiguiente = P00122_A205TipoParSiguiente[0] ;
            AV12GXLvl2 = 1 ;
            AV9TipoParSiguiente = A205TipoParSiguiente ;
            A205TipoParSiguiente = (int)(A205TipoParSiguiente+1) ;
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0))) == 1 )
            {
               AV8TipoParSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0))) == 2 )
            {
               AV8TipoParSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0))) == 3 )
            {
               AV8TipoParSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00" + StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0))) == 4 )
            {
               AV8TipoParSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0" + StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0))) == 5 )
            {
               AV8TipoParSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + StringUtil.Trim( StringUtil.Str( (decimal)(AV9TipoParSiguiente), 10, 0)) ;
            }
            /* Using cursor P00123 */
            pr_default.execute(1, new Object[] {A205TipoParSiguiente, A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio});
            pr_default.close(1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl2 == 0 )
         {
            /*
               INSERT RECORD ON TABLE TipoPartidaDetalle

            */
            A204TipoParAnio = (short)(DateTimeUtil.Year( Gx_date)) ;
            A205TipoParSiguiente = 2 ;
            AV8TipoParSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00001" ;
            /* Using cursor P00124 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A204TipoParAnio, A205TipoParSiguiente});
            pr_default.close(2);
            if ( (pr_default.getStatus(2) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
         }
         AV9TipoParSiguiente = (int)(NumberUtil.Val( AV8TipoParSiguienteC, ".")) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("oObtieneCorrelativoPartida");
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
         Gx_date = DateTime.MinValue ;
         P00122_A41ClinicaCodigo = new String[] {""} ;
         P00122_A199TipoParCodigo = new String[] {""} ;
         P00122_A204TipoParAnio = new short[1] ;
         P00122_A205TipoParSiguiente = new int[1] ;
         AV8TipoParSiguienteC = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecorrelativopartida__default(),
            new Object[][] {
                new Object[] {
               P00122_A41ClinicaCodigo, P00122_A199TipoParCodigo, P00122_A204TipoParAnio, P00122_A205TipoParSiguiente
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV12GXLvl2 ;
      private short A204TipoParAnio ;
      private int AV9TipoParSiguiente ;
      private int A205TipoParSiguiente ;
      private int GX_INS52 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String AV8TipoParSiguienteC ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00122_A41ClinicaCodigo ;
      private String[] P00122_A199TipoParCodigo ;
      private short[] P00122_A204TipoParAnio ;
      private int[] P00122_A205TipoParSiguiente ;
      private int aP2_TipoParSiguiente ;
   }

   public class oobtienecorrelativopartida__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00122 ;
          prmP00122 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Gx_date",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP00123 ;
          prmP00123 = new Object[] {
          new Object[] {"@TipoParSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00124 ;
          prmP00124 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoParSiguiente",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00122", "SELECT [ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente] FROM [TipoPartidaDetalle] WITH (UPDLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo) AND ([TipoParAnio] = YEAR(@Gx_date)) ORDER BY [ClinicaCodigo], [TipoParCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00122,1,0,true,false )
             ,new CursorDef("P00123", "UPDATE [TipoPartidaDetalle] SET [TipoParSiguiente]=@TipoParSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [TipoParAnio] = @TipoParAnio", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00123)
             ,new CursorDef("P00124", "INSERT INTO [TipoPartidaDetalle] ([ClinicaCodigo], [TipoParCodigo], [TipoParAnio], [TipoParSiguiente]) VALUES (@ClinicaCodigo, @TipoParCodigo, @TipoParAnio, @TipoParSiguiente)", GxErrorMask.GX_NOMASK,prmP00124)
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
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
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
