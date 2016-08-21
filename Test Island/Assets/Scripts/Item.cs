using System;

public class Item
{
	private int id;
	private string name;
	private bool stackable;

	public int ID { get; private set; }
	public string Name { get; private set; }
	public bool Stackable { get; private set; }

	public Item (int id, string name, bool stackable)
	{
		this.ID = id;
		this.name = name;
		this.stackable = stackable;
	}
}