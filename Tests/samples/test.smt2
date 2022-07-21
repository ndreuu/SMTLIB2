(set-logic HORN)
(declare-datatypes ((Nat_0 0)) (((Z_0 ) (S_0 (unS_0 Nat_0)))))
(declare-fun diseqNat_0 (Nat_0 Nat_0) Bool)
(declare-fun unS_1 (Nat_0 Nat_0) Bool)
(declare-fun isZ_0 (Nat_0) Bool)
(declare-fun isS_0 (Nat_0) Bool)
(assert (forall ((x_38 Nat_0) (x_37 Nat_0))
	(=> (= x_38 (S_0 x_37))
	    (unS_1 x_37 x_38))))
(assert (isZ_0 Z_0))
(assert (forall ((x_39 Nat_0))
	(isS_0 (S_0 x_39))))
(assert (forall ((x_40 Nat_0))
	(diseqNat_0 Z_0 (S_0 x_40))))
(assert (forall ((x_41 Nat_0))
	(diseqNat_0 (S_0 x_41) Z_0)))
(assert (forall ((x_42 Nat_0) (x_43 Nat_0))
	(=> (diseqNat_0 x_42 x_43)
	    (diseqNat_0 (S_0 x_42) (S_0 x_43)))))
(declare-fun add_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun minus_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun le_0 (Nat_0 Nat_0) Bool)
(declare-fun ge_0 (Nat_0 Nat_0) Bool)
(declare-fun lt_0 (Nat_0 Nat_0) Bool)
(declare-fun gt_0 (Nat_0 Nat_0) Bool)
(declare-fun mult_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun div_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun mod_0 (Nat_0 Nat_0 Nat_0) Bool)
(assert (forall ((y_3 Nat_0))
	(add_0 y_3 Z_0 y_3)))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0) (r_0 Nat_0))
	(=> (add_0 r_0 x_35 y_3)
	    (add_0 (S_0 r_0) (S_0 x_35) y_3))))
(assert (forall ((y_3 Nat_0))
	(minus_0 Z_0 Z_0 y_3)))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0) (r_0 Nat_0))
	(=> (minus_0 r_0 x_35 y_3)
	    (minus_0 (S_0 r_0) (S_0 x_35) y_3))))
(assert (forall ((y_3 Nat_0))
	(le_0 Z_0 y_3)))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0))
	(=> (le_0 x_35 y_3)
	    (le_0 (S_0 x_35) (S_0 y_3)))))
(assert (forall ((y_3 Nat_0))
	(ge_0 y_3 Z_0)))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0))
	(=> (ge_0 x_35 y_3)
	    (ge_0 (S_0 x_35) (S_0 y_3)))))
(assert (forall ((y_3 Nat_0))
	(lt_0 Z_0 (S_0 y_3))))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0))
	(=> (lt_0 x_35 y_3)
	    (lt_0 (S_0 x_35) (S_0 y_3)))))
(assert (forall ((y_3 Nat_0))
	(gt_0 (S_0 y_3) Z_0)))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0))
	(=> (gt_0 x_35 y_3)
	    (gt_0 (S_0 x_35) (S_0 y_3)))))
(assert (forall ((y_3 Nat_0))
	(mult_0 Z_0 Z_0 y_3)))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0) (r_0 Nat_0) (z_2 Nat_0))
	(=>	(and (mult_0 r_0 x_35 y_3)
			(add_0 z_2 r_0 y_3))
		(mult_0 z_2 (S_0 x_35) y_3))))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0))
	(=> (lt_0 x_35 y_3)
	    (div_0 Z_0 x_35 y_3))))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0) (r_0 Nat_0) (z_2 Nat_0))
	(=>	(and (ge_0 x_35 y_3)
			(minus_0 z_2 x_35 y_3)
			(div_0 r_0 z_2 y_3))
		(div_0 (S_0 r_0) x_35 y_3))))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0))
	(=> (lt_0 x_35 y_3)
	    (mod_0 x_35 x_35 y_3))))
(assert (forall ((x_35 Nat_0) (y_3 Nat_0) (r_0 Nat_0) (z_2 Nat_0))
	(=>	(and (ge_0 x_35 y_3)
			(minus_0 z_2 x_35 y_3)
			(mod_0 r_0 z_2 y_3))
		(mod_0 r_0 x_35 y_3))))
(declare-datatypes ((Bin_0 0)) (((One_0 ) (ZeroAnd_0 (projZeroAnd_0 Bin_0)) (OneAnd_0 (projOneAnd_0 Bin_0)))))
(declare-fun diseqBin_0 (Bin_0 Bin_0) Bool)
(declare-fun projZeroAnd_1 (Bin_0 Bin_0) Bool)
(declare-fun projOneAnd_1 (Bin_0 Bin_0) Bool)
(declare-fun isOne_0 (Bin_0) Bool)
(declare-fun isZeroAnd_0 (Bin_0) Bool)
(declare-fun isOneAnd_0 (Bin_0) Bool)
(assert (forall ((x_46 Bin_0) (x_45 Bin_0))
	(=> (= x_46 (ZeroAnd_0 x_45))
	    (projZeroAnd_1 x_45 x_46))))
(assert (forall ((x_48 Bin_0) (x_47 Bin_0))
	(=> (= x_48 (OneAnd_0 x_47))
	    (projOneAnd_1 x_47 x_48))))
(assert (isOne_0 One_0))
(assert (forall ((x_49 Bin_0))
	(isZeroAnd_0 (ZeroAnd_0 x_49))))
(assert (forall ((x_50 Bin_0))
	(isOneAnd_0 (OneAnd_0 x_50))))
(assert (forall ((x_51 Bin_0))
	(diseqBin_0 One_0 (ZeroAnd_0 x_51))))