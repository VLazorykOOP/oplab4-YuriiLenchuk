USE ComputerAccessories;
GO
UPDATE GraphicAdapters
SET Type = @Type, Manufacturer = @Manufacturer, Memory = @Memory
WHERE AdapterId = 1;
GO
