// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class PegsClass : MonoBehaviour
{
	private int turn = 0;	
	private int row = 0;
	
	//Blue Button
	public Button BlueButton;
	 
	Button btn = BlueButton.GetComponent<Button>();
	btn.onClick.AddListener(blueOnClick);
	//Brown
	public Button BrownButton;
	 
	Button btn = BrownButton.GetComponent<Button>();
	btn.onClick.AddListener(brownOnClick);
	
	//Green
	public Button GreenButton;
	 
	Button btn = GreenButton.GetComponent<Button>();
	btn.onClick.AddListener(greenOnClick)
	
	//Purple
	public Button PurpleButton;
	 
	Button btn = PurpleButton.GetComponent<Button>();
	btn.onClick.AddListener(purpleOnClick)
	
	;//Red
	public Button RedButton;
	 
	Button btn = RedButton.GetComponent<Button>();
	btn.onClick.AddListener(redOnClick);
	
	//Yellow
	public Button YellowButton;
	 
	Button btn = BlueButton.GetComponent<Button>();
	btn.onClick.AddListener(yellowOnClick);

	
    public Transform prefab;
    void Start()
    {
		if (turn<4)
		{
			//BLUE
			void blueOnClick()
			{
				Debug.Log("You have clicked the blue button!");
				Instantiate(prefab, new Vector3(60 * turn, row, 0), Quaternion.identity);
				turn++;
			}
			//BROWN
			void brwonOnClick()
			{
				Debug.Log("You have clicked the blue button!");
				Instantiate(prefab, new Vector3(60 * turn, row, 0), Quaternion.identity);
				turn++;
			}
			//GREEN
			void greenOnClick()
			{
				Debug.Log("You have clicked the blue button!");
				Instantiate(prefab, new Vector3(60 * turn, row, 0), Quaternion.identity);
				turn++;
			}
			//PURPLE
			void purpleOnClick()
			{
				Debug.Log("You have clicked the blue button!");
				Instantiate(prefab, new Vector3(60 * turn, row, 0), Quaternion.identity);
				turn++;
			}
			//RED
			void redOnClick()
			{
				Debug.Log("You have clicked the blue button!");
				Instantiate(prefab, new Vector3(60 * turn, row, 0), Quaternion.identity);
				turn++;
			}
			//YELLOW
			void yellowOnClick()
			{
				Debug.Log("You have clicked the blue button!");
				Instantiate(prefab, new Vector3(60 * turn, row, 0), Quaternion.identity);
				turn++;
			}
		}//if turn less than 4 
		else
		{
			turn = 0;
			row + 15;
		}
    }
}