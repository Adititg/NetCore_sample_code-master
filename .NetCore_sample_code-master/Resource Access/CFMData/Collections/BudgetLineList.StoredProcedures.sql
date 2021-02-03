﻿--region Drop Existing Procedures

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
PRINT N'Dropping spCFM_BudgetLine_Select'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_BudgetLine_Select', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_BudgetLine_Select has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_BudgetLine_Select') IS NOT NULL
	DROP PROCEDURE spCFM_BudgetLine_Select

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT>0 BEGIN
PRINT 'The stored procedure drop has succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The stored procedure drop has failed'
GO

DROP TABLE #tmpErrors
GO
--endregion

GO

--region [dbo].[spCFM_BudgetLine_Select]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_BudgetLine_Select]
------------------------------------------------------------------------------------------------------------------------

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO

PRINT N'Creating [dbo].[spCFM_BudgetLine_Select]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_BudgetLine_Select', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_BudgetLine_Select] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_BudgetLine_Select]
	@p_BudgetLineID int = NULL,
	@p_BudgetID int = NULL,
	@p_LineID int = NULL,
	@p_OrderNo int = NULL,
	@p_CategoryID int = NULL,
	@p_FortnightAmount decimal(16, 2) = NULL,
	@p_FortnightAmountHasValue BIT = 0,
	@p_RequiresReceipt bit = NULL,
	@p_IsActive bit = NULL,
	@p_CreatedBy int = NULL,
	@p_CreatedOn datetime = NULL,
	@p_UpdatedBy int = NULL,
	@p_UpdatedByHasValue BIT = 0,
	@p_UpdatedOn datetime = NULL,
	@p_UpdatedOnHasValue BIT = 0
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT
	[BudgetLineID],
	[BudgetID],
	[LineID],
	[OrderNo],
	[CategoryID],
	[FortnightAmount],
	[RequiresReceipt],
	[IsActive],
	[CreatedBy],
	[CreatedOn],
	[UpdatedBy],
	[UpdatedOn]
FROM
    [dbo].[BudgetLine]
WHERE
	([BudgetLineID] = @p_BudgetLineID OR @p_BudgetLineID IS NULL)
	AND ([BudgetID] = @p_BudgetID OR @p_BudgetID IS NULL)
	AND ([LineID] = @p_LineID OR @p_LineID IS NULL)
	AND ([OrderNo] = @p_OrderNo OR @p_OrderNo IS NULL)
	AND ([CategoryID] = @p_CategoryID OR @p_CategoryID IS NULL)
	AND ([FortnightAmount] = @p_FortnightAmount OR (@p_FortnightAmount IS NULL AND @p_FortnightAmountHasValue = 0))
	AND ([RequiresReceipt] = @p_RequiresReceipt OR @p_RequiresReceipt IS NULL)
	AND ([IsActive] = @p_IsActive OR @p_IsActive IS NULL)
	AND ([CreatedBy] = @p_CreatedBy OR @p_CreatedBy IS NULL)
	AND ([CreatedOn] = @p_CreatedOn OR @p_CreatedOn IS NULL)
	AND ([UpdatedBy] = @p_UpdatedBy OR (@p_UpdatedBy IS NULL AND @p_UpdatedByHasValue = 0))
	AND ([UpdatedOn] = @p_UpdatedOn OR (@p_UpdatedOn IS NULL AND @p_UpdatedOnHasValue = 0))

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'Stored procedure creation succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT 'Stored procedure creation failed.'
GO
DROP TABLE #tmpErrors
GO

--endregion

GO

