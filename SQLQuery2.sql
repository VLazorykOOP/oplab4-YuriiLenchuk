USE ComputerAccessories;
GO
UPDATE GraphicAdapters
SET Type = @Type, Manufacturer = @Manufacturer, Memory = @Memory
WHERE AdapterIF = 1;
GO
