/*
               File: oObtieneCorrelativo
        Description: Obtiene Correlativos
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:33.95
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
   public class oobtienecorrelativo : GXProcedure
   {
      public oobtienecorrelativo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecorrelativo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           int aP1_CorrelativoId ,
                           out int aP2_CorrelativoSiguiente )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A61CorrelativoId = aP1_CorrelativoId;
         this.AV8CorrelativoSiguiente = 0 ;
         initialize();
         executePrivate();
         aP2_CorrelativoSiguiente=this.AV8CorrelativoSiguiente;
      }

      public int executeUdp( String aP0_ClinicaCodigo ,
                             int aP1_CorrelativoId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A61CorrelativoId = aP1_CorrelativoId;
         this.AV8CorrelativoSiguiente = 0 ;
         initialize();
         executePrivate();
         aP2_CorrelativoSiguiente=this.AV8CorrelativoSiguiente;
         return AV8CorrelativoSiguiente ;
      }

      public void executeSubmit( String aP0_ClinicaCodigo ,
                                 int aP1_CorrelativoId ,
                                 out int aP2_CorrelativoSiguiente )
      {
         oobtienecorrelativo objoobtienecorrelativo;
         objoobtienecorrelativo = new oobtienecorrelativo();
         objoobtienecorrelativo.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecorrelativo.A61CorrelativoId = aP1_CorrelativoId;
         objoobtienecorrelativo.AV8CorrelativoSiguiente = 0 ;
         objoobtienecorrelativo.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecorrelativo);
         aP2_CorrelativoSiguiente=this.AV8CorrelativoSiguiente;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecorrelativo)stateInfo).executePrivate();
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
         /* Using cursor P00032 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A61CorrelativoId, Gx_date});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A63CorrelativoAnio = P00032_A63CorrelativoAnio[0] ;
            A64CorrelativoSiguiente = P00032_A64CorrelativoSiguiente[0] ;
            AV12GXLvl2 = 1 ;
            AV8CorrelativoSiguiente = A64CorrelativoSiguiente ;
            A64CorrelativoSiguiente = (int)(A64CorrelativoSiguiente+1) ;
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0))) == 1 )
            {
               AV9CorrelativoSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0))) == 2 )
            {
               AV9CorrelativoSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0))) == 3 )
            {
               AV9CorrelativoSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0))) == 4 )
            {
               AV9CorrelativoSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0))) == 5 )
            {
               AV9CorrelativoSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CorrelativoSiguiente), 10, 0)) ;
            }
            /* Using cursor P00033 */
            pr_default.execute(1, new Object[] {A64CorrelativoSiguiente, A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
            pr_default.close(1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl2 == 0 )
         {
            /*
               INSERT RECORD ON TABLE CorrelativoDet

            */
            A63CorrelativoAnio = (short)(DateTimeUtil.Year( Gx_date)) ;
            A64CorrelativoSiguiente = 2 ;
            AV9CorrelativoSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00001" ;
            /* Using cursor P00034 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio, A64CorrelativoSiguiente});
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
         AV8CorrelativoSiguiente = (int)(NumberUtil.Val( AV9CorrelativoSiguienteC, ".")) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("oObtieneCorrelativo");
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
         P00032_A41ClinicaCodigo = new String[] {""} ;
         P00032_A61CorrelativoId = new int[1] ;
         P00032_A63CorrelativoAnio = new short[1] ;
         P00032_A64CorrelativoSiguiente = new int[1] ;
         AV9CorrelativoSiguienteC = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecorrelativo__default(),
            new Object[][] {
                new Object[] {
               P00032_A41ClinicaCodigo, P00032_A61CorrelativoId, P00032_A63CorrelativoAnio, P00032_A64CorrelativoSiguiente
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
      private short A63CorrelativoAnio ;
      private int A61CorrelativoId ;
      private int AV8CorrelativoSiguiente ;
      private int A64CorrelativoSiguiente ;
      private int GX_INS21 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String AV9CorrelativoSiguienteC ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00032_A41ClinicaCodigo ;
      private int[] P00032_A61CorrelativoId ;
      private short[] P00032_A63CorrelativoAnio ;
      private int[] P00032_A64CorrelativoSiguiente ;
      private int aP2_CorrelativoSiguiente ;
   }

   public class oobtienecorrelativo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00032 ;
          prmP00032 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@Gx_date",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP00033 ;
          prmP00033 = new Object[] {
          new Object[] {"@CorrelativoSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CorrelativoSiguiente",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00032", "SELECT [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente] FROM [CorrelativoDet] WITH (UPDLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo and [CorrelativoId] = @CorrelativoId) AND ([CorrelativoAnio] = YEAR(@Gx_date)) ORDER BY [ClinicaCodigo], [CorrelativoId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00032,1,0,true,false )
             ,new CursorDef("P00033", "UPDATE [CorrelativoDet] SET [CorrelativoSiguiente]=@CorrelativoSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId AND [CorrelativoAnio] = @CorrelativoAnio", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00033)
             ,new CursorDef("P00034", "INSERT INTO [CorrelativoDet] ([ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente]) VALUES (@ClinicaCodigo, @CorrelativoId, @CorrelativoAnio, @CorrelativoSiguiente)", GxErrorMask.GX_NOMASK,prmP00034)
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
