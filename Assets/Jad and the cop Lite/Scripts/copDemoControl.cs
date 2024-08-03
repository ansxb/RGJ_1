using UnityEngine;
using System.Collections;
using Spine;
using Spine.Unity;

public class copDemoControl : MonoBehaviour
{
    #region Inspector
    // [SpineAnimation] attribute allows an Inspector dropdown of Spine animation names coming form SkeletonAnimation.
    [SpineAnimation]
    public string idleAnimation;

    [SpineAnimation]
    public string walkAnimation;

    [SpineAnimation]
    public string deadAnimation;

    

    #endregion

    SkeletonAnimation skeletonAnimation;

    // Spine.AnimationState and Spine.Skeleton are not Unity-serialized objects. You will not see them as fields in the inspector.
    public Spine.AnimationState spineAnimationState;
    public Spine.Skeleton skeleton;
    // Start is called before the first frame update
    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        spineAnimationState = skeletonAnimation.AnimationState;
        skeleton = skeletonAnimation.Skeleton;
    }

    public void idle()
    {
        spineAnimationState.SetAnimation(0, idleAnimation, true);
    }
    public void dead()
    {
        spineAnimationState.SetAnimation(0, deadAnimation, true);
    }
    public void walk()
    {
        spineAnimationState.SetAnimation(0, walkAnimation, true);
    }
    

}
